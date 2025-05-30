public class Solution {
    public bool IsPalindrome(int x) {
          int Number = x;
  if (x < 0)
  {
      Console.WriteLine($"{x} is Negative");
  }
  else
  {
      int rev = 0;
      while (x>0) {
          int digit = x % 10;
          rev = rev * 10 + digit;
          x = x / 10;
      }

      if (Number == rev) {
          return true;
      }
        }
  return false; 
    }
}