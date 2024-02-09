//https://app.codility.com/programmers/trainings/4/str_symmetry_point/

using System;
using System.Linq;

class Solution {
    public int solution(string S) {
        if(S.Length % 2 == 0)
            return -1;

        if(S.Length == 1)
            return 0;

        int mid = S.Length / 2;
        string left = new string(S.Substring(0, mid).Reverse().ToArray());
        string right = S.Substring(mid + 1);
        return left == right ? mid : -1;
    }
}