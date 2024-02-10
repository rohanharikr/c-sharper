//https://leetcode.com/problems/longest-substring-without-repeating-characters/

public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<char> set = new();
        int l = 0, max = 0;

        for(int r = 0; r < s.Length;)
        {
            if(!set.Contains(s[r]))
            {
                set.Add(s[r]);
                r++;
                max = Math.Max(max, r - l);
            } else
            {
                set.Remove(s[l]);
                l++;
            }
        }
        
        return max;
    }
}