public class Solution {
    public int MostFrequentEven(int[] nums) {
        int count =0;
        int number=0;
      for(int i=0;i<nums.Length;i++){
        int temp=0;
        for(int j=0;j<nums.Length;j++){
            if(nums[i]==nums[j] && nums[i]%2==0){
                    temp++;
            }
        }
        if(count<temp){
            count =temp;
            number=nums[i];
        }
        if(count==temp){
            if(nums[i]<number){
                number=nums[i];
            }
        }
      }
      if(count==0){
        return -1;
      }else
        return number;
    }
}