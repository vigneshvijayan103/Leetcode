public class Solution {
    public int AddDigits(int num) {

        while(num>=10){
            int num1=num/10;
            int num2=num%10;
            num =num1+num2;
        }
        return num;
    }
}
