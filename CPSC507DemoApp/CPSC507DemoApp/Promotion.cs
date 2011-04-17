using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPSC507DemoApp
{
    public class Promotion
    {
        private String id;
        private ItemCategory category;
        private IList<String> descriptionKeywords;
        private DateTime startTime;
        private DateTime endTime;
        private double discount;

        public Promotion(String id, ItemCategory category, List<String> descriptionKeywords,
                DateTime startTime, DateTime endTime, double discount)
        {
            this.id = id;
            this.category = category;
            this.descriptionKeywords = new List<String>(descriptionKeywords);
            this.startTime = startTime;
            this.endTime = endTime;
            this.discount = discount;
        }

        public String getId()
        {
            return id;
        }

        public ItemCategory getCategory()
        {
            return category;
        }

        public IList<String> getDescriptionKeywords()
        {
            return descriptionKeywords;
        }

        public DateTime getStartTime()
        {
            return startTime;
        }

        public DateTime getEndTime()
        {
            return endTime;
        }

        public double getDiscount()
        {
            return discount;
        }
    }
}
