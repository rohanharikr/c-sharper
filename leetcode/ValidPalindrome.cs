//https://leetcode.com/problems/valid-palindrome/

public class Solution {
    public bool IsPalindrome(string s) {
        var str = s.Where(i => Char.IsLetter(i) || Char.IsNumber(i)).Select(i => Char.ToLower(i)).ToList();
        if(str.Count == 0)
            return true;

        for(int i = 0; i < str.Count; i++)
            if(str[i] != str[str.Count - 1 - i])
                return false;

        return true;
    }
}