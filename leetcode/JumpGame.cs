//https://leetcode.com/problems/jump-game/

public class Solution {
    public bool CanJump(int[] nums) {
        int nearest = nums.Length - 1;
        for(int i = nums.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(i + nums[i]);
            if(i + nums[i] >= nearest)
                nearest = i;
        }
        if(nearest == 0)
            return true;
        
        return false;
    }
}