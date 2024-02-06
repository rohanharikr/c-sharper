//https://app.codility.com/programmers/lessons/4-counting_elements/missing_integer/

using System;

class Solution {
    public int solution(int[] A) {
        Array.Sort(A);
        int smallest = 1;

        for(int i = 0; i < A.Length; i++)
        {
            if(A[i] == smallest)
                smallest++;
        }

        return smallest;
    }
}