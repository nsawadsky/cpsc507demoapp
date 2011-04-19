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
        /// <summary>Test stub for calculateCost(IList`1&lt;Promotion&gt;, Int32)</summary>
        [PexMethod]
        public CostAndApplicablePromotions calculateCost(
            [PexAssumeUnderTest]Order target,
            [PexAssumeNotNull]Promotion[] promotions,
            int allowablePromotions
        )
        {
            PexAssume.AreElementsNotNull(promotions);

            CostAndApplicablePromotions result
               = target.calculateCost(new List<Promotion>(promotions), allowablePromotions);
            return result;
            // TODO: add assertions to method OrderTest.calculateCost(Order, IList`1<Promotion>, Int32)
        }
    }
}
