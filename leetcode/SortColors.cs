//https://leetcode.com/problems/sort-colors/

public class Solution {
    public void SortColors(int[] nums) {
        if(nums.Length == 0 || nums.Length == 1)
            return;
        
        int left = 0;
        int right = nums.Length - 1;
        int index = 0;
        while(index <= right)
        {
            if(nums[index] == 0)
            {   
                nums[index] = nums[left];
                nums[left] = 0;
                left++;
                index++;
            } else if(nums[index] == 2)
            {
                nums[index] = nums[right];
                nums[right] = 2;
                right--;
            } else {
                index++;
            }
        }
    }
}