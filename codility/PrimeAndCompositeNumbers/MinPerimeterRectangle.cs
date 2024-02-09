//https://app.codility.com/programmers/lessons/10-prime_and_composite_numbers/min_perimeter_rectangle/

using System;

class Solution {
    public int solution(int N) {
        int permieter = 0;
        for(int i = (int)Math.Sqrt(N); i >= 1; i--)
        {
            if(N % i == 0)
            {
                permieter = (2 * (i + N / i));
                break;
            }
        }
        return permieter;
    }
}