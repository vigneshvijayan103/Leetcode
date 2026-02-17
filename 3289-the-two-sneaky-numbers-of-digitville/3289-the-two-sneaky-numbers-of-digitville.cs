public class Solution {
    public int[] GetSneakyNumbers(int[] nums) {
        int[] result=new int[2];
        int k=0;
        for(int i=0;i<nums.Length;i++){
            for(int j=i+1;j<nums.Length;j++){
                if(nums[i]==nums[j]){
                    result[k]=nums[i];
                    k++;
                }
            }
        }
        return result;
    }
}