public class Solution {
    public int SubtractProductAndSum(int n) {
        int product=1;
        int sum=0;
       
        while(n!=0){
            int lastdigit=n%10;
             n=n/10;
            product*=lastdigit;
            sum+=lastdigit;
        }

        return product-sum;
    }
}