//https://leetcode.com/problems/missing-number/

public class Solution {
    public int MissingNumber(int[] nums) {
        int[] range = Enumerable.Range(0, nums.Max() + 1).ToArray();
        int[] missing = range.Except(nums).ToArray();
        if(missing.Length == 0)
            return nums.Max() + 1;
        return missing[0];
    }
}