public class Solution {
    public char FindTheDifference(string s, string t) {
        char result='\0';
        foreach(char  i in s){
              result^=i;
            }
            foreach(char j in t ){
                result^=j;
            }
            return result;
        
    }
}


