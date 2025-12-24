public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
       
       int i=0;
        
       for(int j=0;j<nums1.Length;j++){
        if(nums1[j]==0 && i<n){
            nums1[j]=nums2[i];
              i++;
       }

  

        

       
    }
      Array.Sort(nums1);
}
}