//https://app.codility.com/programmers/lessons/4-counting_elements/max_counters/
//Task Score 77%
//Correctness 100%
//Performance 60%

using System;
using System.Linq;
using System.Collections.Generic;

class Solution {
    public int[] solution(int N, int[] A) {
        int[] counters = new int[N];
        Array.Fill(counters, 0);
        int maxValue = 0;
        foreach(int i in A)
        {
            if(i > N)
                Array.Fill(counters, maxValue);
            else {
                int index = i - 1;
                counters[index]++;
                maxValue = Math.Max(counters[index], maxValue);
            }
        }
        return counters;
    }
}