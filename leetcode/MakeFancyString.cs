//https://leetcode.com/problems/delete-characters-to-make-fancy-string/

public class Solution {
    public string MakeFancyString(string s) {
        if(s.Length <= 2)
            return s;
            
        StringBuilder str = new(s.Substring(0, 2));
        for(int i = 2; i < s.Length; i++)
        {
            if(s[i - 1] == s[i] && s[i - 2] == s[i])
                continue;
            
            str.Append(s[i]);
        }
        return str.ToString();
    }
}