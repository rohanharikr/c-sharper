//https://app.codility.com/programmers/lessons/5-prefix_sums/passing_cars/

using System;

class Solution {
    public int solution(int[] A) {
        int east = 0;
        int passing = 0;
        foreach(int i in A)
        {
            if(i == 0)
                east++;
            else if(passing > 1000000000)
                return -1;
            else
                passing += east;
        }
        return passing;
    }
}