//https://leetcode.com/problems/is-subsequence/

public class Solution {
    public bool IsSubsequence(string s, string t) {
        if(string.IsNullOrEmpty(s))
            return true;

        Stack<char> stack = new Stack<char>(s.ToCharArray());
        for(int i = t.Length - 1; i >= 0; i--)
        {
            if(stack.Count == 0)
                return true;

            if(t[i] == stack.Peek())
                stack.Pop();
        }

        return stack.Count == 0;
    }
}