using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPSC507DemoApp
{
    public interface Serializer
    {
        String serialize(Object obj);
    
        T deserialize<T>(String serialized);
    }
}
