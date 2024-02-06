//https://leetcode.com/problems/two-sum/description/

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] res = new int[2];
        for(int i = 0; i < nums.Length; i++)
            for(int j = 0; j < nums.Length; j++)
            {
                if(i == j)
                    continue;

                int sum = nums[i] + nums[j];
                if(sum == target)
                {
                    res[0] = i;
                    res[1] = j;
                }
            }
        
        return res;
    }
}