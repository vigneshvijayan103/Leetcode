public class Solution {
    public int[] NumberGame(int[] nums) {
        Array.Sort(nums);
        int[]result=new int[nums.Length];
        for(int i=0;i<nums.Length-1;i++){
            int temp=nums[i];
            nums[i]=nums[i+1];
            nums[i+1]=temp;
            result[i]=nums[i];
            result[i+1]=nums[i+1];
            i++;
        }
        return result;
    }
}