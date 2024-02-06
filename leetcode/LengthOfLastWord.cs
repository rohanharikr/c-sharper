//https://leetcode.com/problems/length-of-last-word/

public class Solution {
    public int LengthOfLastWord(string s) {
        string[] arr = s.Trim().Split(" ").ToArray();
        return arr[arr.Length - 1].Length;
    }
}