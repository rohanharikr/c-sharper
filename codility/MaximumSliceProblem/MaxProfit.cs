//https://app.codility.com/programmers/lessons/9-maximum_slice_problem/max_profit/

using System;

class Solution {
    public int solution(int[] A) {
        int buy = Int32.MaxValue;
        int profit = 0;
        foreach(int i in A)
        {
            if(i < buy)
                buy = i;
            else
                profit = Math.Max(profit, i - buy);
        }
        return profit;
    }
}