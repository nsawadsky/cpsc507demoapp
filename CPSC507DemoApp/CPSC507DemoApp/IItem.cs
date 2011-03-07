using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPSC507TestApp
{
    public interface IItem
    {
        long ID { get; }
        DateTime Timestamp { get; }
    }
}
