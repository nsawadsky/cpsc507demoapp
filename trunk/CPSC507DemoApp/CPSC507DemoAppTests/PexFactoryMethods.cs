using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CPSC507DemoApp;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;

namespace CPSC507DemoAppTests
{
    public static class PexFactoryMethods
    {
        [PexFactoryMethod(typeof(Promotion))]
        public static Promotion createPromotion(
            [PexAssumeNotNull]String id, ItemCategory category,
            [PexAssumeNotNull]String[] descriptionKeywords,
            DateTime startTime, DateTime endTime, double discount)
        {
            PexAssume.AreElementsNotNull(descriptionKeywords);
            PexAssume.IsTrue(discount >= 0.01);
            PexAssume.IsTrue(discount <= 0.99);

            return new Promotion(id, category, new List<String>(descriptionKeywords), startTime, endTime, discount);
        }

        [PexFactoryMethod(typeof(Order))]
        public static Order createOrder(DateTime creationTime, [PexAssumeNotNull]OrderItemAndQuantity[] orderItems)
        {
            PexAssume.AreElementsNotNull(orderItems);

            Order order = new Order(creationTime);
            foreach (OrderItemAndQuantity item in orderItems)
            {
                order.addItems(item.getItem(), item.getQuantity());
            }
            return order;
        }

        [PexFactoryMethod(typeof(OrderItem))]
        public static OrderItem createOrderItem(
            [PexAssumeNotNull]String id, ItemCategory category, [PexAssumeNotNull]String description, double price)
        {
            PexAssume.IsTrue(price >= 0.01);
            OrderItem item = new OrderItem(id, category, description, price);
            return item;
        }

        [PexFactoryMethod(typeof(OrderItemAndQuantity))]
        public static OrderItemAndQuantity createOrderItemAndQuantity(OrderItem item, int quantity)
        {
            PexAssume.InRange(quantity, 1, 1000);
            OrderItemAndQuantity itemAndQuantity = new OrderItemAndQuantity(item, quantity);
            return itemAndQuantity;
        }

    }
}
