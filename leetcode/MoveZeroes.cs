//https://leetcode.com/problems/move-zeroes/

public class Solution {
    public void MoveZeroes(int[] nums) {
        int left = 0;
        for(int right = 0; right < nums.Length; right++)
        {
            if(nums[right] == 0)
                continue;
            
            int temp = nums[left];
            nums[left] = nums[right];
            nums[right] = temp;
            left++;
        }
    }
}