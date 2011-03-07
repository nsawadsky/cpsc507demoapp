// <copyright file="ItemDictionaryComparerTest.cs">Copyright ©  2011</copyright>
using System;
using CPSC507TestApp;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CPSC507TestApp
{
    /// <summary>This class contains parameterized unit tests for ItemDictionaryComparer</summary>
    [PexClass(typeof(ItemDictionaryComparer))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class ItemDictionaryComparerTest
    {
        /// <summary>Test stub for CompareDictionaries()</summary>
        [PexMethod]
        public ItemDictionaryComparer.CompareResults CompareDictionaries(IItem[] arr1, IItem[] arr2)
        {
            // <pex>
            PexAssume.IsNotNull((object)arr1, "arr1");
            // </pex>
            IDictionary<long, IItem> dict1 = new Dictionary<long, IItem>();
            foreach (IItem item in arr1)
            {
                // <pex>
                PexAssume.IsNotNull((object)item, "item");
                // </pex>
                dict1[item.ID] = item;
            }
            // <pex>
            PexAssume.IsNotNull((object)arr2, "arr2");
            // </pex>
            IDictionary<long, IItem> dict2 = new Dictionary<long, IItem>();
            foreach (IItem item in arr2)
            {
                // <pex>
                PexAssume.IsNotNull((object)item, "item");
                // </pex>
                dict2[item.ID] = item;
            }

            ItemDictionaryComparer target = new ItemDictionaryComparer(dict1, dict2);
            ItemDictionaryComparer.CompareResults result = target.CompareDictionaries();

            foreach (IItem item in target.Dict2.Values)
            {
                if (!target.Dict1.ContainsKey(item.ID))
                {
                    PexAssert.IsTrue(result.Added.ContainsKey(item.ID));
                }
            }
            return result;
        }
    }
}
