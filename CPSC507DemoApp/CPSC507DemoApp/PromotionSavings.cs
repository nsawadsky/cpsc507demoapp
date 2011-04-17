﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPSC507DemoApp
{
    public class PromotionSavings
    {
        private Promotion promotion;
        private double savings;

        public Promotion getPromotion()
        {
            return promotion;
        }

        public double getSavings()
        {
            return savings;
        }

        public PromotionSavings(Promotion promotion, double savings)
        {
            this.promotion = promotion;
            this.savings = savings;
        }
    }
}