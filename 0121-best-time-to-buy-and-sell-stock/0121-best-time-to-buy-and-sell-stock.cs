public class Solution {
    public int MaxProfit(int[] prices) {
      int min=prices[0];
        int maxprofit=0;

        for(int i=1;i<prices.Length;i++){
            if(prices[i]<min){
                min=prices[i];
            }
           int profit=prices[i]-min;
           if(maxprofit<profit){
            maxprofit=profit;
           }
           
        

        }
        return maxprofit;
    }
}