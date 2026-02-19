public class Solution {
    public int[] Shuffle(int[] nums, int n) {
        int []result=new int[nums.Length];
      int k=0;
      int j=n;
      for(int i=0;i<nums.Length-1;i++){
          if(k<nums.Length  && j<nums.Length){
                result[k]=nums[i];
            result[k+1]=nums[j];
            j++;
               k=k+2; 
            }
      }
      return result;
    }
}