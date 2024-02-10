//https://leetcode.com/problems/two-sum/description/

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] res = new int[2];
        for(int i = 0; i < nums.Length; i++)
        {
            int diff = target - nums[i];
            int diffIndex = Array.IndexOf(nums, diff);
            if(diffIndex == -1 || diffIndex == i)
                continue;
            
            res = [ i, diffIndex ];
            break;
        }

        return res;
    }
}