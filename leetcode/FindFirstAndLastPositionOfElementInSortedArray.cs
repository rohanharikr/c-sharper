//https://leetcode.com/problems/find-first-and-last-position-of-element-in-sorted-array/

public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        int[] indices = { -1, -1 };
        for(int i = 0; i < nums.Length; i++)
        {
            bool numIsTarget = nums[i] == target;
            if(!numIsTarget)
                continue;

            if(indices[0] == -1)
                indices[0] = i;
            
            if(indices[0] != -1)
                indices[1] = i;
        }
        return indices;
    }
}