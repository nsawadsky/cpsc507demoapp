using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CPSC507TestApp;

namespace CPSC507TestApp
{
    public class ItemDictionaryComparer
    {
        private IDictionary<long, IItem> dict1;
        private IDictionary<long, IItem> dict2;

        public class CompareResults
        {
            private IDictionary<long, IItem> added;
            private IDictionary<long, IItem> removed;
            private IDictionary<long, IItem> updated;

            public CompareResults(IDictionary<long, IItem> added, IDictionary<long, IItem> removed, 
                IDictionary<long, IItem> updated)
            {
                this.added = added;
                this.removed = removed;
                this.updated = updated;
            }

            public IDictionary<long, IItem> Added
            {
                get
                {
                    return added;
                }
            }

            public IDictionary<long, IItem> Removed
            {
                get
                {
                    return removed;
                }
            }

            public IDictionary<long, IItem> Updated
            {
                get
                {
                    return Updated;
                }
            }
        }

        public ItemDictionaryComparer(IDictionary<long, IItem> dict1, IDictionary<long, IItem> dict2)
        {
            this.dict1 = dict1;
            this.dict2 = dict2;
        }

        public IDictionary<long, IItem> Dict1
        {
            get
            {
                return dict1;
            }
        }

        public IDictionary<long, IItem> Dict2
        {
            get
            {
                return dict2;
            }
        }

        public CompareResults CompareDictionaries()
        {
            IDictionary<long, IItem> added = new Dictionary<long, IItem>(dict2);
            IDictionary<long, IItem> removed = new Dictionary<long, IItem>();
            IDictionary<long, IItem> updated = new Dictionary<long, IItem>();

            foreach (IItem item1 in dict1.Values)
            {
                IItem item2 = null;
                dict2.TryGetValue(item1.ID, out item2);

                if (item2 == null)
                {
                    removed.Add(item1.ID, item1);
                }
                else
                {
                    added.Remove(item1.ID);
                    if (!item2.Timestamp.Equals(item1.Timestamp))
                    {
                        updated.Add(item2.ID, item2);
                    }
                }
            }
            return new CompareResults(added, removed, updated);
        }

    }
}
