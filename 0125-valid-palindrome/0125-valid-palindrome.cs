public class Solution {
    public bool IsPalindrome(string s) {
         string newString="";
        string reverse = "";
        foreach (var item in s.ToLower())
        {
            if (char.IsLetterOrDigit(item)){
                newString += item;
            }
        }

        Console.WriteLine(newString);
        for (int i = newString.Length - 1; i >= 0; i--)
        {
            reverse += newString[i];
        }
        if (reverse == newString)
        {
            return true;
        }
        return false;
    }
}