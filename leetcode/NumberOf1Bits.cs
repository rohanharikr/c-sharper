//https://leetcode.com/problems/number-of-1-bits/

using System.Linq;

public class Solution {
    public int HammingWeight(uint n) {
        string binary = Convert.ToString(n, 2);
        return binary.Count(i => i == '1');
    }
}