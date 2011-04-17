using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPSC507DemoApp
{
    public interface StorageManager
    {
        void storeObject(String category, String id, String data);
    
        void deleteObject(String category, String id);
    
        List<String> loadObjects(String category);
    }
}
