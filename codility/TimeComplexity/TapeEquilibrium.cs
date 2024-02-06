//https://app.codility.com/programmers/lessons/3-time_complexity/tape_equilibrium/

using System;
using System.Linq;

class Solution {
    public int solution(int[] A) {
        int totalSum = A.Sum();
        int leftSum = 0;
        int lowest = int.MaxValue;

        for(int i = 0; i < A.Length - 1; i++)
        {
            leftSum += A[i];
            int rightSum = totalSum - leftSum;
            int difference = Math.Abs(rightSum - leftSum);
            
            if(difference < lowest)
                lowest = difference;
        }

        return lowest;
    }
}