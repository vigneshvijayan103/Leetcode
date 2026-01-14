public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {

        Dictionary<int,int> Duplicate=new Dictionary<int,int>();

        for(int i=0;i<nums.Length;i++){
            if(Duplicate.ContainsKey(nums[i])){
                if(Math.Abs(i-Duplicate[nums[i]])<=k){
                    return true;
                }
            }
            Duplicate[nums[i]]=i;
        }
        return false;
    }
}