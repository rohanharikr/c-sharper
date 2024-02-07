//https://leetcode.com/problems/maximum-nesting-depth-of-the-parentheses/

public class Solution {
    public int MaxDepth(string s) {
        int depth = 0;
        int maxDepth = 0;
        foreach(char c in s)
        {
            if(c == '(')
                depth++;
            else if(c == ')')
                depth--;
            
            maxDepth = Math.Max(depth, maxDepth);
        }
        
        return maxDepth;
    }
}