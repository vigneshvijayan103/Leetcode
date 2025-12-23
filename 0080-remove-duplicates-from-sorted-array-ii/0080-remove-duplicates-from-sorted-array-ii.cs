public class Solution {
    public int RemoveDuplicates(int[] nums) {
       int i=0;
       int temp=0;
       for(int j=1;j<nums.Length;j++){

            if(nums[i]!=nums[j]){
                    temp=0;
                    i++;
                    nums[i]=nums[j];
                }
         else{
            temp++;
        }
        if(temp==1){
             i++;
            nums[i]=nums[j];
           

        }
            
       } 

       return i+1;
    }
}