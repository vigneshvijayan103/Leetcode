public class Solution {
    public int FindNonMinOrMax(int[] nums) {
        Array.Sort(nums);
         if(nums.Length>=3)
            return nums[1];
        return -1;
    }
}