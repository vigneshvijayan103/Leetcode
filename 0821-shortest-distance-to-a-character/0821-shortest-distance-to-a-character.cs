public class Solution {
    public int[] ShortestToChar(string s, char c) {

        int []result=new int[s.Length];
        for(int i=0;i<s.Length;i++){
            int min=s.Length;
            for(int j=0;j<s.Length;j++){
                if(s[j]==c){
                    int distance=Math.Abs(i-j);
                    if(distance<min){
                        min=distance;
                    }
                }
            }
            result[i]=min;

        }
        return result;
    }
}