public class Solution {
    public int MaxProfit(int[] prices) {
       
       int minprices=prices[0];
       int maxProfit=0;

       for(int i=1;i<prices.Length;i++){
        if(prices[i]<minprices){
            minprices=prices[i];
        }
           int profit=prices[i]-minprices;
           if(profit>maxProfit){
            maxProfit=profit;
           }
       }

          

        
         return maxProfit;
       }
    
    
    
}