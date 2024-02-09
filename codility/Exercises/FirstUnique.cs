//https://app.codility.com/programmers/trainings/4/first_unique/

using System;
using System.Linq;
using System.Collections.Generic;

class Solution {
    public int solution(int[] A) {
        if(A.Length == 1)
            return A[0];

        for(int i = 0; i < A.Length; i++)
        {
            bool foundOnLeft = A.Take(i).Contains(A[i]);
            bool foundOnRight = A.Skip(i + 1).Contains(A[i]);
            if(!foundOnLeft && !foundOnRight)
                return A[i];
        }
        return -1;
    }
}