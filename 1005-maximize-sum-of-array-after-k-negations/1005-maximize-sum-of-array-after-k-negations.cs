public class Solution {
    public int LargestSumAfterKNegations(int[] nums, int k) {
        Array.Sort(nums);
        int sum=0;
        int minvalue=0;

        for(int i=0;i<nums.Length;i++){
            if(k>0 && nums[i]<0){
                nums[i]=-nums[i];
                k--;
            }
            if(nums[i]<nums[minvalue]){
                minvalue=i;

            }
       
        }

        if(k%2!=0){
            nums[minvalue]=- nums[minvalue];
        }

        foreach(int j in nums){
            sum+=j;
        }

        return sum;
    }
}