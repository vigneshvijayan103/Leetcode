public class Solution {
    public int MajorityElement(int[] nums) {
       
        int count=0;
        
        int number=nums[0];
        for(int i=0;i<nums.Length;i++){
            if(count==0){
             
                number=nums[i];
            }

            if(nums[i]==number){
                count++;
            }else{
                count--;
            }
            
        }

        return number;
        
    }
}