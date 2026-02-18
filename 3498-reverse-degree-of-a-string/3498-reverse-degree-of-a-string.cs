public class Solution {
    public int ReverseDegree(string s) {

        int sum=0;
        for(int i=0;i<s.Length;i++){
            int rev=char.ToUpper(s[i]);
          int reverse=26-(s[i]-'a');
          sum+=reverse*(i+1);
        }
        return sum;
    }
}