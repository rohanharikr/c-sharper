//https://leetcode.com/problems/house-robber/

public class Solution {
    public int Rob(int[] nums) {
        if(nums.Length == 0)
            return 0;

        int[] memo = new int[nums.Length + 1];
        memo[0] = 0;
        memo[1] = nums[0];

        for(int i = 2; i <= nums.Length; i++) {
            memo[i] = Math.Max(memo[i - 2] + nums[i - 1], memo[i - 1]);
        }

        return memo[nums.Length];
    }
}
