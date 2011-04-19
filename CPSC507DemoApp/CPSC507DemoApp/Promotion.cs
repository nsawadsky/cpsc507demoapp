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

        public override bool Equals(Object obj)
        {
            Promotion target = obj as Promotion;
            if (target == null)
            {
                return false;
            }
            return Object.Equals(this.id, target.id) &&
                Object.Equals(this.category, target.category) &&
                descriptionKeywordsMatch(this.descriptionKeywords, target.descriptionKeywords) &&
                Object.Equals(this.startTime, target.startTime) &&
                Object.Equals(this.endTime, target.endTime) &&
                this.discount == target.discount;
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

        private static bool descriptionKeywordsMatch(IList<String> key1, IList<String> key2)
        {
            if (key1 == null && key2 == null)
            {
                return true;
            }
            if (key1 == null || key2 == null)
            {
                return false;
            }
            if (key1.Count != key2.Count)
            {
                return false;
            }
            for (int i = 0; i < key1.Count; i++)
            {
                if (!Object.Equals(key1[i], key2[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
