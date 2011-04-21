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
            String id, ItemCategory category,
            String[] descriptionKeywords,
            DateTime startTime, DateTime endTime, double discount)
        {
            return new Promotion(id, category, new List<String>(descriptionKeywords), startTime, endTime, discount);
        }

        [PexFactoryMethod(typeof(OrderItem))]
        public static OrderItem createOrderItem(
            String id, ItemCategory category, String description, double price)
        {
            OrderItem item = new OrderItem(id, category, description, price);
            return item;
        }

        [PexFactoryMethod(typeof(OrderItemAndQuantity))]
        public static OrderItemAndQuantity createOrderItemAndQuantity(OrderItem item, int quantity)
        {
            OrderItemAndQuantity itemAndQuantity = new OrderItemAndQuantity(item, quantity);
            return itemAndQuantity;
        }

        [PexFactoryMethod(typeof(Order))]
        public static Order createOrder(DateTime creationTime, OrderItemAndQuantity[] lineItems)
        {
            Order order = new Order(creationTime);
            if (lineItems != null)
            {
                foreach (OrderItemAndQuantity lineItem in lineItems)
                {
                    order.addItems(lineItem.getItem(), lineItem.getQuantity());
                }
            }
            return order;
        }
    }
}
