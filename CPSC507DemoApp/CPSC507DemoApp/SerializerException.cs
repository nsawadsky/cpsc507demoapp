using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPSC507DemoApp
{
    public class SerializerException : Exception
    {
        public SerializerException(String message, Exception cause) : base(message, cause)
        {
        }
    }
}
