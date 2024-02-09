//https://app.codility.com/programmers/lessons/16-greedy_algorithms/tie_ropes/

using System;

class Solution {
    public int solution(int K, int[] A) {
        int current = 0;
        int count = 0;
        foreach(int i in A)
        {
            current += i;
            if(current >= K)
            {
                count++;
                current = 0;
            }
        }
        return count; 
    }
}