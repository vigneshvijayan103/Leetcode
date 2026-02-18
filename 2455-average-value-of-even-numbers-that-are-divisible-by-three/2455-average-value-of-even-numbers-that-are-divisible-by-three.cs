public class Solution {
    public int AverageValue(int[] nums) {
        int sum=0;
        int count=0;
       foreach(int i in nums){
        if(i%3==0 && i%2==0){
            sum+=i;
            count++;
        }
       } 
       if(count>0){
        return sum/count;
       }
       return 0;
    }
}