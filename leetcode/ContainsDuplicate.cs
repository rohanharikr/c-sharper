//https://leetcode.com/problems/contains-duplicate/

public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        List<int> deduped = new List<int>();
        foreach(int i in nums)
        {
            if(deduped.Contains(i))
                return true;
            
            deduped.Add(i);
        }
        return false;
    }
}