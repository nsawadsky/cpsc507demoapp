using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPSC507TestApp
{
    public class Item: IItem
    {
        private long id;
        private DateTime timestamp;

        public Item(long id, DateTime timestamp)
        {
            this.id = id;
            this.timestamp = timestamp;
        }

        public long ID
        {
            get 
            { 
                return id; 
            }
        }

        public DateTime Timestamp
        {
            get 
            {
                return timestamp;
            }
        }
    }
}
