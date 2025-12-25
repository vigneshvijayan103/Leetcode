public class Solution {
    public int[] SortedSquares(int[] nums) {
        for(int i=0;i<nums.Length;i++){
            nums[i]=nums[i]*nums[i];
        }
        for(int j=0;j<nums.Length;j++){
            for(int k=j+1;k<nums.Length;k++){
                if(nums[j]>nums[k]){
                    int temp=nums[j];
                    nums[j]=nums[k];
                    nums[k]=temp;
                }
            }        }
        
        return nums;
    }
}