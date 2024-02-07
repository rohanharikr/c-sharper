//https://leetcode.com/problems/remove-trailing-zeros-from-a-string/

public class Solution {
    public string RemoveTrailingZeros(string num) {
        for(int i = num.Length - 1; i >= 0; i-- )
        {
            if(num[i] != '0')
                break;
            
            num = num.Remove(i);
        }

        return num;
    }
}