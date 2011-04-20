// <copyright file="OrderTest.cs">Copyright ©  2011</copyright>
using System;
using System.Collections.Generic;
using CPSC507DemoApp;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CPSC507DemoApp
{
    /// <summary>This class contains parameterized unit tests for Order</summary>
    [PexClass(typeof(Order))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class OrderTest
    {
        [PexMethod(Timeout = 100, MaxRunsWithoutNewTests = 300, MaxConstraintSolverTime = 2)]
        public void testCalculateCost(
            [PexAssumeUnderTest]Order target,
            [PexAssumeNotNull]Promotion[] promotions,
            int allowablePromotions
        )
        {
            CostAndApplicablePromotions result = target.calculateCost(new List<Promotion>(promotions), 
                allowablePromotions);

            CostAndApplicablePromotions expectedResult = calculateCostAndApplicablePromotions(
                target, new List<Promotion>(promotions), allowablePromotions);

            PexAssert.AreEqual(expectedResult.getCost(), result.getCost());

            assertPromotionSavingsListsMatch(expectedResult.getApplicablePromotions(),
                result.getApplicablePromotions());
        }

        private void assertPromotionSavingsListsMatch(IList<PromotionSavings> expected,
            IList<PromotionSavings> actual)
        {
            if (actual.Count != expected.Count)
            {
                PexAssert.Fail("expected.Count = " + expected.Count + ", actual.Count = " + actual.Count);
            }
            foreach (PromotionSavings savings in expected)
            {
                if (savings == null)
                {
                    PexAssert.Fail("null reference in expected promotion savings list");
                }
                if (!actual.Contains(savings))
                {
                    PexAssert.Fail("Actual is missing savings object for promotion '"
                        + savings.getPromotion().getId() + "'");
                }
            }
            foreach (PromotionSavings savings in actual)
            {
                if (savings == null)
                {
                    PexAssert.Fail("null reference in actual promotion savings list");
                }
                if (!expected.Contains(savings))
                {
                    PexAssert.Fail("Actual contains unexpected savings object for promotion '"
                        + savings.getPromotion().getId() + "'");
                }
            }
        }

        private CostAndApplicablePromotions calculateCostAndApplicablePromotions(
            Order target, IList<Promotion> promotions, int allowablePromotions)
        {
            double cost = 0.0;
            foreach (OrderItemAndQuantity itemAndQuantity in target.getLineItems())
            {
                cost += itemAndQuantity.getQuantity() * itemAndQuantity.getItem().getPrice();
            }

            List<PromotionSavings> applicablePromotions = new List<PromotionSavings>();
            foreach (Promotion promo in promotions)
            {
                double savings = 0.0;
                bool promoMatched = false;
                foreach (OrderItemAndQuantity itemAndQuantity in target.getLineItems())
                {
                    if (itemAndQuantity.getItem().getCategory() == promo.getCategory())
                    {
                        if (target.getCreationTime().CompareTo(promo.getStartTime()) >= 0 &&
                            target.getCreationTime().CompareTo(promo.getEndTime()) <= 0) 
                        {
                            bool descriptionKeywordMatch = false;
                            if (promo.getDescriptionKeywords() == null || promo.getDescriptionKeywords().Count == 0)
                            {
                                descriptionKeywordMatch = true;
                            }
                            else
                            {
                                foreach (String keyword in promo.getDescriptionKeywords())
                                {
                                    if (itemAndQuantity.getItem().getDescription().Contains(keyword))
                                    {
                                        descriptionKeywordMatch = true;
                                        break;
                                    }
                                }
                            }
                            if (descriptionKeywordMatch)
                            {
                                promoMatched = true;
                                savings += promo.getDiscount() * (itemAndQuantity.getItem().getPrice() * itemAndQuantity.getQuantity());
                            }
                        }
                    }
                }
                if (promoMatched)
                {
                    applicablePromotions.Add(new PromotionSavings(promo, savings));
                }
            }
            if (applicablePromotions.Count > allowablePromotions)
            {
                applicablePromotions.Sort((Comparison<PromotionSavings>)((x, y) => y.getSavings().CompareTo(x.getSavings())));
                applicablePromotions = applicablePromotions.GetRange(0, allowablePromotions);
            }
            foreach (PromotionSavings savings in applicablePromotions)
            {
                cost -= savings.getSavings();
            }
            return new CostAndApplicablePromotions(cost, applicablePromotions);
        }
    }
}
