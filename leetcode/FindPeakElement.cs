//https://leetcode.com/problems/find-peak-element/

public class Solution {
    public int FindPeakElement(int[] nums) {
        if (nums.Length <= 1) 
            return 0;

        for (int i = 0; i < nums.Length - 1; i++) {
            if (nums[i] > nums[i + 1]) {
                return i;
            }
        }

        return nums.Length - 1;
    }
}