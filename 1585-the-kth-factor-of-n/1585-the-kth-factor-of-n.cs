public class Solution {
    public int KthFactor(int n, int k) {
       
        int len=0;

        for(int i=1;i<=n;i++){
            if(n%i==0){
                len++;
            }
        }

        int[]numbers=new int[len];

        int index=0;
        for(int i=1;i<=n;i++){
            if(n%i==0){
                numbers[index]=i;
                index++;
            }
             

         }

      if(k>numbers.Length){
            return -1;
        }
 return numbers[k-1];
       
    }
}