public class Solution {
    public long MaximumHappinessSum(int[] happiness, int k) {
        Array.Sort(happiness);
        Array.Reverse(happiness);
        long  sum=0;
        int turns=0;
        for(int i=0;i<k;i++){
            if(happiness[i]-turns>=0){

            
            sum+=happiness[i]-turns;
            turns++;
            }
        }
        return sum;
    }
}