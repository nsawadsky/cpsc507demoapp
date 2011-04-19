using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPSC507DemoApp
{
    public class PromotionSavings
    {
        private Promotion promotion;
        private double savings;

        public PromotionSavings(Promotion promotion, double savings)
        {
            this.promotion = promotion;
            this.savings = savings;
        }

        public override bool Equals(Object obj)
        {
            PromotionSavings target = obj as PromotionSavings;
            if (target == null)
            {
                return false;
            }
            return savings == target.savings && Object.Equals(promotion, target.promotion);
        }

        public Promotion getPromotion()
        {
            return promotion;
        }

        public double getSavings()
        {
            return savings;
        }

    }
}
