public class Solution {
    public int BestClosingTime(string customers) {
        int penalty =0;
        int hour=0;
       
       foreach(char c in customers){
         if(c=='Y'){
            penalty++;
         }
       }
       int minPenalty=penalty;
       
       for(int i=0;i<customers.Length;i++){
        if(customers[i]=='Y'){
            penalty--;
        }else{
            penalty++;
        }
        if(minPenalty>penalty){
            minPenalty=penalty;
            hour=i+1;
        }
       }
       return hour;
    }
}