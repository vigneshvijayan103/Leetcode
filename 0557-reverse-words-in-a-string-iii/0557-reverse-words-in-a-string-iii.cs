public class Solution {
    public string ReverseWords(string s) {
        string[] words=s.Split(' ');
       
        for(int i=0;i<words.Length;i++){
            char[]letter=words[i].ToCharArray();
            Array.Reverse(letter);
            words[i]=new string(letter);
        }

        string result=string.Join(" ",words);
        return result;
        
    }
}