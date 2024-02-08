//https://leetcode.com/problems/replace-all-s-to-avoid-consecutive-repeating-characters/

public class Solution {
    public string ModifyString(string s) {
        if(s.Length == 1 && s[0] == '?')
            return "a";
            
        char[] arr = s.ToCharArray();
        for(int i = 0; i < arr.Length; i++)
        {
            if(arr[i] != '?')
                continue;

            for(int j = 97; j <= 123; j++) //97 - 123 [a-z] range 
            {
                char alphabet = (char)j;
                if(
                    (i == 0 && arr[i + 1] != alphabet) || //first
                    (i == arr.Length - 1 && arr[i - 1] != alphabet) || //last
                    (i > 0 && arr[i - 1] != alphabet && //between 0 and n
                    i < arr.Length - 1 && arr[i + 1] != alphabet)
                )
                {
                    arr[i] = alphabet;
                    break;
                };
            }
        }
        return new String(arr);
    }
}