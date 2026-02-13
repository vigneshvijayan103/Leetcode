public class Solution {
    public int MissingInteger(int[] nums) {
        int count=1;
        int sum=0;
        for(int i=1;i<nums.Length;i++){
            if(nums[i]==nums[i-1]+1){
                count++;
            }else{
               break;
            }
        }

        for(int i=0;i<count;i++){
            sum+=nums[i];
        }  

          for(int j=0;j<nums.Length;j++){
            if(sum==nums[j]){
                sum++;
                j=0;
            }
        }

    return sum;

        
    }
}