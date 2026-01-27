public class Solution {
    public int HammingWeight(int n) {
       string bitvalue=Convert.ToString(n,2);
        int count=0; 

        foreach(char i in bitvalue){
            if(i=='1'){
                count++;
            }
        }
        return count;
    }
}