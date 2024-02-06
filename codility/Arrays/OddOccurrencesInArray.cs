//https://app.codility.com/programmers/lessons/2-arrays/odd_occurrences_in_array/

using System;
using System.Linq;
using System.Collections.Generic;

class Solution {
    public int solution(int[] A) {
        HashSet<int> occ = new HashSet<int>();
        foreach(int i in A)
        {
            if(occ.Contains(i))
                occ.Remove(i)
            else
                occ.Add(i)
        }
        return occ.First();
    }
}