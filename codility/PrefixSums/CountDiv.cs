//https://app.codility.com/programmers/lessons/5-prefix_sums/count_div/

using System;

class Solution {
    public int solution(int A, int B, int K) {
        int divisors = (B / K) - (A / K);
        if(A % K == 0)
            divisors++;
        
        return divisors;
    }
}
