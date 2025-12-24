public class Solution {
    public int CountKDifference(int[] nums, int k) {
        
        int count=0;
        for(int i=0;i<nums.Length;i++){
            for(int j=i+1;j<nums.Length;j++){
            if(nums[i]-nums[j]==k || nums[j]-nums[i]==k){
                count++;
            }
        }
    }
        return count;
    }
}