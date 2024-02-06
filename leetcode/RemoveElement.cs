//https://leetcode.com/problems/remove-element/

public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int count = 0;
        foreach(int i in nums)
            if(i != val)
            {
                nums[count] = i;
                count++;
            }
            
        return count;
    }
}