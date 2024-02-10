//https://leetcode.com/problems/two-sum/description/

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] res = new int[2];
        for(int i = 0; i < nums.Length; i++)
        {
            int diff = target - nums[i];
            int index = Array.IndexOf(nums, diff);
            if(index == -1 || index == i)
                continue;
            
            res = [ i, index ];
            break;
        }

        return res;
    }
}