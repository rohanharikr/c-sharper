//https://app.codility.com/programmers/lessons/6-sorting/distinct/
//Task Score 75%
//Correctness 100%
//Performance 0%

using System;
using System.Collections.Generic;

class Solution {
    public int solution(int[] A) {
        return new HashSet<int>(A).Count;
    }
}