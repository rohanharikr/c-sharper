//https://leetcode.com/problems/best-time-to-buy-and-sell-stock/

public class Solution {
    public int MaxProfit(int[] prices) {
        int buy = Int32.MaxValue;
        int profit = 0;
        foreach(int i in prices)
        {
            if(i < buy)
                buy = i;
            else
                profit = Math.Max(profit, i - buy);
        }
        return profit;
    }
}