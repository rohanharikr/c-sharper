//https://app.codility.com/programmers/lessons/10-prime_and_composite_numbers/count_factors/
//Task Score 71%
//Correctness 100%
//Performance 33%

using System;

class Solution {
    public int solution(int N) {
        int factorsCount = 0;
        
        for(int i = 1; i <= N; i++)
            if(N % i == 0)
                factorsCount++;

        return factorsCount;
    }
}