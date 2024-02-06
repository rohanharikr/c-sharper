//https://app.codility.com/programmers/lessons/3-time_complexity/frog_jmp/

using System;

class Solution {
    public int solution(int X, int Y, int D) {
        return (int)Math.Ceiling((double)(Y - X) / D);
    }
}