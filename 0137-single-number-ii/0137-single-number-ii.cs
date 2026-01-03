public class Solution {
    public int SingleNumber(int[] nums) {
        int count=1;
        int number=0;
        for(int i=0;i<nums.Length;i++){
            int temp=0;
            for(int j=0;j<nums.Length;j++){
                if(nums[i]==nums[j]){
                    temp++;
                   
                }
            }
           
            if(count==temp){
                number=nums[i];
            }
           
        }
        return number;
    }
}