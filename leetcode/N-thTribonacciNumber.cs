//https://leetcode.com/problems/n-th-tribonacci-number/

public class Solution {
    public int Tribonacci(int n) {
        int[] arr = new int[3] { 0, 1, 1 };
        if(n < 3)
            return arr[n];

        for(int i = 3; i <= n; i++)
            arr = [ arr[1], arr[2], arr.Sum() ];

        return arr[2];
    }
}