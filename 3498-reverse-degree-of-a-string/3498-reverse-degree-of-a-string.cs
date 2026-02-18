public class Solution {
    public int ReverseDegree(string s) {

        int sum=0;
        for(int i=0;i<s.Length;i++){
            int rev=char.ToUpper(s[i]);
          int reverse='Z'-char.ToUpper(s[i])+1;
          Console.WriteLine(reverse);
          int product=(i+1)*reverse;
          Console.WriteLine("pro"+product);
          sum+=product;
        }
        return sum;
    }
}