//https://leetcode.com/problems/longest-common-prefix/

public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        string prefix = string.Empty;
        for(int i = 0; i < strs[0].Length; i++)
        {
            char letter = strs[0][i];
            for(int j = 0; j < strs.Length; j++)
            {
                bool letterExists = strs[j].Length > i;
                if(!letterExists)
                    return prefix;
                
                bool letterIsPrefix = strs[j][i] == letter;
                if(!letterIsPrefix)
                    return prefix;
            }
            prefix += letter;
        }
        return prefix;
    }
}