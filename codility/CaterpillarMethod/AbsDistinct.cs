//https://app.codility.com/programmers/lessons/15-caterpillar_method/abs_distinct/

using System;
using System.Linq;
using System.Collections.Generic;

class Solution {
    public int solution(int[] A) {
        var deduped = A.Select(i => Math.Abs((long)i)).Distinct();
        return new HashSet<long>(deduped).Count;
    }
}