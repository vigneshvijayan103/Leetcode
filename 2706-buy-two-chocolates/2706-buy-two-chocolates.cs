public class Solution {
    public int BuyChoco(int[] prices, int money) {
        int number=money;
      Array.Sort(prices);
        int sumOfTwo=prices[0]+prices[1];
        if(sumOfTwo<=money)
              number-=sumOfTwo;
              return number;
            return money;
       


        
    }
}