public class Solution {
    public string ReversePrefix(string s, int k) {
        string name="";
         
            for(int i=k-1;i>=0;i--){
                name+=s[i];
            }
            for(int j=k;j<s.Length;j++){
                name+=s[j];
            }

            return name;
    }
}