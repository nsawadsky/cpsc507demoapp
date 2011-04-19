using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPSC507DemoApp
{
    public class Order
    {
        private IDictionary<String, OrderItemAndQuantity> lineItems = new Dictionary<String, OrderItemAndQuantity>();
        private DateTime creationTime;

        public Order(DateTime creationTime) {
            this.creationTime = creationTime;
        }
        public DateTime getCreationTime() {
            return creationTime;
        }
    
        public void addItems(OrderItem item, int quantity) {
            OrderItemAndQuantity lineItem = null;
            lineItems.TryGetValue(item.getId(), out lineItem);
            if (lineItem == null) {
                lineItem = new OrderItemAndQuantity(item, quantity);
                lineItems[item.getId()] = lineItem;
            } else {
                lineItem.setQuantity(lineItem.getQuantity() + quantity);
            }
        }
    
        public void removeItems(OrderItem item, int quantity) {
            OrderItemAndQuantity lineItem = null;
            lineItems.TryGetValue(item.getId(), out lineItem);
            if (lineItem != null) {
                if (lineItem.getQuantity() > quantity) {
                    lineItem.setQuantity(lineItem.getQuantity() - quantity);
                } else {
                    lineItems.Remove(item.getId());
                }
            }
        }

        public CostAndApplicablePromotions calculateCost(IList<Promotion> promotionList, 
                int allowablePromotions) {
            double totalCost = calculateCostBeforePromotions();
        
            List<PromotionSavings> promoSavingsList = new List<PromotionSavings>();
        
            if (allowablePromotions > 0) {
                promoSavingsList = calculateAllPromotionSavings(promotionList);
            
                if (promoSavingsList.Count > allowablePromotions) {
                    // Sort the savings list in descending order according to savings value.
                    promoSavingsList.Sort((Comparison<PromotionSavings>)((arg0, arg1) => arg1.getSavings().CompareTo(arg0.getSavings())));
                    promoSavingsList = promoSavingsList.GetRange(0, allowablePromotions);
                }
            
                foreach (PromotionSavings promoSavings in promoSavingsList) {
                    totalCost -= promoSavings.getSavings();
                }
            
            }
            return new CostAndApplicablePromotions(totalCost, promoSavingsList);
        }
    
        private List<PromotionSavings> calculateAllPromotionSavings(IList<Promotion> promotionList) {
            List<PromotionSavings> result = new List<PromotionSavings>();
            foreach (Promotion promo in promotionList) {
                PromotionSavings savings = calculatePromotionSavings(promo);
                if (savings != null)
                {
                    result.Add(savings);
                }
            }
            return result;
        }
    
        private PromotionSavings calculatePromotionSavings(Promotion promotion) {
            if (creationTime.CompareTo(promotion.getStartTime()) >= 0 && 
                    creationTime.CompareTo(promotion.getEndTime()) <= 0) {
                foreach (OrderItemAndQuantity lineItem in lineItems.Values) {
                    OrderItem orderItem = lineItem.getItem();
                    if (orderItem.getCategory().Equals(promotion.getCategory())) {
                        bool descriptionMatch = false;
                        if (promotion.getDescriptionKeywords() == null || 
                                promotion.getDescriptionKeywords().Count == 0) {
                            descriptionMatch = true;
                        } else {
                            foreach (String keyword in promotion.getDescriptionKeywords()) {
                                if (orderItem.getDescription().Contains(keyword)) {
                                    descriptionMatch = true;
                                }
                            }
                        }
                        if (descriptionMatch) {
                            double savings = promotion.getDiscount() * 
                                (lineItem.getQuantity() * orderItem.getPrice());
                            return new PromotionSavings(promotion, savings);
                        }
                    }
                }
            }
            return null;
        }
    
        private double calculateCostBeforePromotions() {
            double result = 0.0;
            foreach (OrderItemAndQuantity lineItem in lineItems.Values){
                result += lineItem.getQuantity() * lineItem.getItem().getPrice();
            }
            return result;
        }
    }
}
