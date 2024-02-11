//https://leetcode.com/problems/maximum-average-subarray-i/

public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        if(k == 1)
            return nums.Max();

        if(nums.Length <= k)
            return (double)nums.Sum() / k;

        int maxSum = nums.Take(k).Sum();
        int currentSum = maxSum;
        for(int i = k; i < nums.Length; i++)
        {
            currentSum += nums[i] - nums[i - k];
            maxSum = Math.Max(maxSum, currentSum);
        }

        return (double)maxSum / k;
    }
}