//https://app.codility.com/programmers/lessons/1-iterations/binary_gap/

using System;

class Solution {
    public int solution(int N) {
        string binary = Convert.ToString(N, 2);
        int count = 0, max = 0;
        foreach(char c in binary)
        {
            if(c == '0')
                count++;
            else 
            {
                if(count > max)
                    max = count;
                    
                count = 0;
            }
        }

        return max;
    }
}
