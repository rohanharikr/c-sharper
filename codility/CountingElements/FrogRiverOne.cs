//https://app.codility.com/programmers/lessons/4-counting_elements/frog_river_one/

using System;
using System.Collections.Generic;

class Solution {
    public int solution(int X, int[] A) {
        HashSet<int> pos = new HashSet<int>();
        int distinctCount = 0;

        for (int i = 0; i < A.Length; i++) {
            if (A[i] <= X && pos.Add(A[i])) {
                distinctCount++;

                if (distinctCount == X)
                    return i;
            }
        }
        return -1;
    }
}