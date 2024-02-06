//https://leetcode.com/problems/climbing-stairs/

public class Solution {
    public int ClimbStairs(int n) {
        if(n <= 2) 
            return n;
        
        int prev1 = 1, prev2 = 2;
        int current = 0;
        for(int i = 2; i <= n-1; i++)
        {
            current = prev1 + prev2;
            prev1 = prev2; 
            prev2 = current;
        }
        return current;
    }
}