public class Solution {
    public string RemoveTrailingZeros(string num) {
        string number="";
        int count=0;        
        for(int i=num.Length-1;i>=0;i--){
            if(num[i]=='0'){
                count++;
            }else{
                break;
            }
        }
        int len=num.Length-count;
        string result=num.Substring(0,len);
        return result;          
    }
}