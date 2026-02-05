public class Solution {
    public bool HasTrailingZeros(int[] nums) {
        int count=0;
        foreach(int  i in nums){
         string binary = Convert.ToString(i, 2);
         if(binary[binary.Length-1]=='0'){
            count++;
         }
        }
        if(count>=2){
            return true;
        }
        return false;
    }
}