//https://leetcode.com/problems/longer-contiguous-segments-of-ones-than-zeros/

public class Solution {
    public bool CheckZeroOnes(string s) {
        if(!s.Contains('0'))
            return true;

        char prev = s[0];
        int count = 0, longestZero = 0, longestOne = 0;
        for(int i = 0; i < s.Length; i++)
        {
            if(prev != s[i])
            {
                count = 0;
                prev = s[i];
            }

            if(prev == '0')
                longestZero = Math.Max(longestZero, ++count);
            else
                longestOne = Math.Max(longestOne, ++count);
        }

        return longestOne > longestZero;
    }
}
