public class Solution {
    public int CountEven(int num) {
        int count=0;
        for(int i=1;i<=num;i++){

            if(i<10 && i%2==0){
                count++;
            }
            else{
                int sum=0;
                int temp=i;
                while(temp>0){
                    sum+=temp%10;
                    temp/=10;
                }
                if(sum%2==0){
                    count++;
                }
            }
          
        }
         return count;
    }
}