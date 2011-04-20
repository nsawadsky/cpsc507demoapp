using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPSC507DemoApp
{
    public class OrderItemAndQuantity
    {
        private int quantity;
        private OrderItem item;

        public OrderItemAndQuantity(OrderItem item, int quantity)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            if (quantity < 0)
            {
                throw new ArgumentOutOfRangeException("quantity");
            }
            this.item = item;
            this.quantity = quantity;
        }

        public int getQuantity()
        {
            return quantity;
        }

        public void setQuantity(int quantity)
        {
            this.quantity = quantity;
        }

        public OrderItem getItem()
        {
            return item;
        }
    }
}
