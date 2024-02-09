using System;

class Solution {
    public int solution(int N) {
        int factors = 0;
        for(int i = 1; i <= Math.Sqrt(N); i++)
            if(N % i == 0)
                factors++;

        if(N % Math.Sqrt(N) == 0)
            return (factors * 2) - 1;

        return factors * 2;
    }
}