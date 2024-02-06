//https://app.codility.com/programmers/lessons/9-maximum_slice_problem/max_profit/
//Task Score 66%
//Correctness 100%
//Performance 25%

using System;

class Solution {
    public int solution(int[] A) {
        int max = 0;
        for(int i = 0; i < A.Length; i++)
        {
            int dayStart = A[i];
            for(int j = i + 1; j < A.Length; j++)
            {
                int dayEnd  = A[j]; 
                int profitLoss = dayEnd - dayStart;
                max = Math.Max(profitLoss, max);
            }
        }
        return max;
    }
}