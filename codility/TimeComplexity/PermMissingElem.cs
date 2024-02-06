//https://app.codility.com/programmers/lessons/3-time_complexity/perm_missing_elem/

using System;

class Solution {
    public int solution(int[] A) {
        if (A.Length == 0)
            return 1;

        int n = A.Length + 1;
        long expectedSum = (long)n * (n + 1) / 2;
        long actualSum = 0;

        for (int i = 0; i < A.Length; i++) {
            actualSum += A[i];
        }

        return (int)(expectedSum - actualSum);
    }
}