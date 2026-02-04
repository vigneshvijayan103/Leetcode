public class Solution {
    public int BuyChoco(int[] prices, int money) {
        int number=money;
        int buy=0;
      Array.Sort(prices);
        for(int i=0;i<prices.Length;i++){
            if( buy<2 && prices[i]<=number && number>0){
                number-=prices[i];
                Console.WriteLine(number);
                buy++;
            }
            
        }
        if(buy==2){
            return number;
        }
        else{
            return money;
        }
        
    }
}