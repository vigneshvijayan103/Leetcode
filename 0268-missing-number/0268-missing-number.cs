public class Solution {
    public int MissingNumber(int[] nums) {
        int len=nums.Length;
        int sum=0;
        int sum2=0;

        foreach(int i in nums){
            sum+=i;
        }

        for(int j=0;j<=len;j++){
            sum2+=j;
        }

        return sum2-sum;
    }
}