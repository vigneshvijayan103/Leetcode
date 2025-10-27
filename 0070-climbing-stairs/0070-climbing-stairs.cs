public class Solution {
    public int ClimbStairs(int n) {
        if (n==1){
            return 1;
        }               
        if(n==2){
            return 2;    
        }
          int first=1;
          int second=2;        
          int total=0;

        for(int i=3;i<=n;i++){

           total=first+second;
           first=second;
           second=total;
        }
        return total;
    }
}