public class Solution {
    public int[] SingleNumber(int[] nums) {
        int[]result=new int[2];
        int k=0;
        for(int i=0;i<nums.Length;i++){
            int count=0;
            for(int j=0;j<nums.Length;j++){
                if(nums[i]==nums[j])
                        count++; 
            }
            if(count==1 && k<=1){
                result[k]=nums[i];
                k++;
            }
                
        }
        return result;
    }
}