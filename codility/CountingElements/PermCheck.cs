//https://app.codility.com/programmers/lessons/4-counting_elements/perm_check/

using System;
using System.Linq;

class Solution {
    public int solution(int[] A) {
        Array.Sort(A);
        for(int i = 0; i <= A.Length - 1; i++)
            if(A[i] != (i + 1))
                return 0;

        return 1;
    }
}