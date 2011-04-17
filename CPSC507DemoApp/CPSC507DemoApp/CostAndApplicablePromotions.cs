using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPSC507DemoApp
{
    public class CostAndApplicablePromotions
    {
        private double cost;
        private IList<PromotionSavings> applicablePromotions;

        public CostAndApplicablePromotions(double cost,
                IList<PromotionSavings> applicablePromotions)
        {
            this.cost = cost;
            this.applicablePromotions = applicablePromotions;
        }
        public double getCost()
        {
            return cost;
        }
        public IList<PromotionSavings> getApplicablePromotions()
        {
            return applicablePromotions;
        }

    }
}
