//https://app.codility.com/programmers/lessons/12-euclidean_algorithm/chocolates_by_numbers/
//Task Score 50%
//Correctness 100%
//0%

using System;
using System.Collections.Generic;

class Solution {
    public int solution(int N, int M) {
        HashSet<int> eaten = new HashSet<int>();
        int index = 0;
        while(true)
        {
            int num = index % N;
            if(!eaten.Add(num))
                break;

            index += M;
        }

        return eaten.Count;
    }
}