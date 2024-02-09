//Incorrect

using System;
using System.Collections.Generic;

class Solution {
    public int solution(int[] A) {
        List<int> peaks = new List<int>();
        for(int i = 1; i < A.Length - 1; i++)
            if(A[i] > A[i - 1] && A[i] > A[i + 1])
                peaks.Add(i);

        if(peaks.Count <= 1)
            return peaks.Count;

        int flags = 0;
        int leftPtr = 0;
        int rightPtr = peaks.Count - 1;
        while(leftPtr <= rightPtr)
        {
            int diff = Math.Abs(peaks[leftPtr] - peaks[rightPtr]);
            if(diff >= peaks.Count)
                flags++;
            
            if(leftPtr > rightPtr)
                rightPtr--;
            else
                leftPtr++;
        }

        return flags;
    }
}