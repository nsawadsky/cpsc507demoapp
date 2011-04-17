using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPSC507DemoApp
{
    public class StorageException : Exception
    {
        public StorageException(String arg0, Exception arg1) : base(arg0, arg1)
        {
        }
    }
}
