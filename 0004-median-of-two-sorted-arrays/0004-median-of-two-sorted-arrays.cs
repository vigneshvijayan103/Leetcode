public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int[] merged = nums1.Concat(nums2).OrderBy(x => x).ToArray();

        double median=0.0;
         int index=merged.Length/2;
        if(merged.Length%2==0){

        // double sum=merged[0]+merged[merged.Length-1];
        double sum=merged[index-1]+merged[index];
         median=sum/2;
        return median;

        }
       
        median=merged[index];

        return median;

        
    
    


    }

}