//https://app.codility.com/programmers/lessons/2-arrays/cyclic_rotation/

using System;
using System.Linq;
using System.Collections.Generic;

class Solution {
    public int[] solution(int[] A, int K) {
        if(A.Length == 0)
            return A;

        List<int> list = A.ToList();
        int lastIndex = list.Count - 1;
        for(int i = 0; i < K; i++)
        {
            int last = list[lastIndex];
            list.RemoveAt(lastIndex);
            list.Insert(0, last);
        }

        return list.ToArray();
    }
}
