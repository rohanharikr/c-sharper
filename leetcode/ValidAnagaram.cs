//https://leetcode.com/problems/valid-anagram/

public class Solution {
    public bool IsAnagram(string s, string t) {
        char[] sStr = s.ToCharArray();
        char[] tStr = t.ToCharArray();
        Array.Sort(sStr);
        Array.Sort(tStr);
        return new string(sStr) == new string(tStr);
    }
}