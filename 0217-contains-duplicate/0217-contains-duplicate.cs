public class Solution {
    public bool ContainsDuplicate(int[] nums) {

        HashSet<int> duplicate=new HashSet<int>();
        foreach(int num in nums){
            if(duplicate.Contains(num)){
                return true;
                 }
                 duplicate.Add(num);
            }
            return false;
     }
    
}