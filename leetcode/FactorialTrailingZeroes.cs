//https://leetcode.com/problems/factorial-trailing-zeroes/

public class Solution {
    public int TrailingZeroes(int n) {
        int count = 0;
        while(n >= 5)
        {
            n /= 5;
            count += n;
        }

        return count;
    }
}