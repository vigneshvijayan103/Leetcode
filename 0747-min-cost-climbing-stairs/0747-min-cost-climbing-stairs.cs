public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        int n=cost.Length;
      int[]dp=new int[n];
      dp[0]=cost[0];
      dp[1]=cost[1];
      int result=0;
      for(int i=2;i<n;i++){
        int minValue;
        if(dp[i-1]<dp[i-2]){
            minValue=dp[i-1];
        }
            else{
                 minValue=dp[i-2];
            }
           
         dp[i]=cost[i]+minValue; 
         
      }
        

        if(dp[n-1]<dp[n-2])
           return result=dp[n-1];
            else
               return result=dp[n-2];


    }
}