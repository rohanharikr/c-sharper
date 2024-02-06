//https://leetcode.com/problems/reverse-words-in-a-string/

public class Solution {
    public string ReverseWords(string s) {
        List<string> arr = s.Trim().Split(" ").Where(i =>
            !string.IsNullOrWhiteSpace(i) ||
            string.IsNullOrWhiteSpace(i) && i.Length > 1).Reverse().ToList();
        return string.Join(" ", arr);
    }
}