public class Solution {
    public bool IsHappy(int n) {
        HashSet<int>exist=new HashSet<int>();
    while (n != 1 && !exist.Contains(n)) {
         exist.Add(n);
         n = SumOfSquares(n);
        }
    return n == 1;
    }
  
    private int SumOfSquares(int n){
          int sum=0;
        while(n>0){
            int digit=n%10;
            sum+=digit * digit;
            n/=10;
        }
        return sum;
    }
  
    
}
    
