/**
 * @param {number[]} prices
 * @return {number}
 */
var maxProfit = function(prices) {
     let minprofit=prices[0];
     let maxProfit=0;
     
     for(i=1;i<prices.length;i++){
         if(prices[i]<minprofit){
            minprofit=prices[i];
         }

         let profit=prices[i]-minprofit;
         if(profit>maxProfit){
            maxProfit=profit;
         }
     }

     return maxProfit;
};