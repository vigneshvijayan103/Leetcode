public class Solution {
    public string MergeAlternately(string word1, string word2) {
        string result="";
        
        for(int i=0;i<word1.Length;i++){
            result+=word1[i];
           if(i<word2.Length){
            result+=word2[i];
           }
        }
        if(word1.Length<word2.Length){
             int diff= word2.Length-word1.Length;
             string append=word2.Substring(word2.Length - diff);
             result+=append;
        }
        return result;
    }
}