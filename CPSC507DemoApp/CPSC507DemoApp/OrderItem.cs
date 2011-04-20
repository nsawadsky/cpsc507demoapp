using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPSC507DemoApp
{
    public class OrderItem
    {
        private String id;
        private ItemCategory category;
        private String description;
        private double price;

        public OrderItem(String id, ItemCategory category, String description, double price)
        {
            if (id == null)
            {
                throw new ArgumentNullException("id");
            }
            if (description == null)
            {
                throw new ArgumentNullException("description");
            }
            if (price < 0.0)
            {
                throw new ArgumentOutOfRangeException("price");
            }
            this.id = id;
            this.category = category;
            this.description = description;
            this.price = price;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (obj.GetType() != this.GetType())
            {
                return false;
            }
            OrderItem target = (OrderItem)obj;
            return Object.Equals(this.id, target.id) && this.category == target.category &&
                Object.Equals(this.description, target.description) && this.price == target.price;
        }

        public String getId()
        {
            return id;
        }

        public ItemCategory getCategory()
        {
            return category;
        }

        public String getDescription()
        {
            return description;
        }

        public double getPrice()
        {
            return price;
        }

    }
}
