public class Solution {
    public int MinimumBoxes(int[] apple, int[] capacity) {
        int sum=0;
        int count=0;
        for(int i=0;i<apple.Length;i++){
            sum+=apple[i];

        }   
       
         Array.Sort(capacity);

        for(int j=capacity.Length-1;j>=0;j--){
            
            sum-=capacity[j];
            count++;
           

            if(sum<=0){
              break;  
          
            }
        }

         return count;
       

    }
}