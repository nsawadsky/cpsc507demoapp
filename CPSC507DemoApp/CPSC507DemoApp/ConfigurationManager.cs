using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPSC507DemoApp
{
    public class ConfigurationManager
    {
        private Serializer serializer;
        private StorageManager storageManager;
    
        private const String PROMO_CATEGORY = "Promotion";
    
        public ConfigurationManager(Serializer serializer, StorageManager storageManager) {
            this.serializer = serializer;
            this.storageManager = storageManager;
        }
    
        public void storePromotion(Promotion promo) {
            String serialized = serializer.serialize(promo);
            storageManager.storeObject(PROMO_CATEGORY, promo.getId(), serialized);
        }
    
        public void deletePromotion(String id) {
            storageManager.deleteObject(PROMO_CATEGORY, id);
        }
    
        public IList<Promotion> loadPromotions() {
            IList<String> promoData = storageManager.loadObjects(PROMO_CATEGORY);
            IList<Promotion> result = new List<Promotion>();
            foreach (String data in promoData) {
                result.Add(serializer.deserialize<Promotion>(data));
            }
            return result;
        }
    }
}
