//https://leetcode.com/problems/remove-duplicates-from-sorted-array/

public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if(nums.Length == 0)
            return 0;

        int count = 0;
        int first = nums[0];
        int last = nums[nums.Length - 1];
        for(int i = first; i <= last; i++)
            if(nums.Contains(i))
            {
                nums[count] = i;
                count++;
            }

        return count;
    }
}