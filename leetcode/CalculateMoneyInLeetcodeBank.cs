//https://leetcode.com/problems/calculate-money-in-leetcode-bank/

public class Solution {
    public int TotalMoney(int n) {
        if(n <= 7)
            return n * (n + 1) / 2;

        int sum = 28;
        int inc = 1;
        for(int i = 8; i <= n; i++)
        {
            sum += ((i % 7 == 0 ? 7 : i % 7) + inc);
            
            if(i % 7 == 0)
                inc++;
        }
        return sum;
    }
}