public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length!=t.Length){
            return false;
        }

        char[] b=t.ToCharArray();

       for(int i=0;i<s.Length;i++){
           bool res=false; 
        for(int j=0;j<b.Length;j++){
            if(s[i]==b[j]){
               b[j]='/';
               res=true;
                break;
            }

        }
        if(!res){
            return false;
        }
       }
       return true;
    }
}