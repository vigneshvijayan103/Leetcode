public class Solution {
    public string ReversePrefix(string word, char ch) {
        int index=0;
        for(int i=0;i<word.Length;i++){
           if(word[i]==ch){
                index=i;
                break;
            }
        }

            var reverse=word.ToCharArray();
            int left=0;
            int right=index;

            while(left<right){
                char temp=reverse[left];
                reverse[left]=reverse[right];
                reverse[right]=temp;
                left++;
                right--;
            }

            return new String(reverse);


        
    }
}