//https://leetcode.com/problems/summary-ranges/

public class Solution {
    public IList<string> SummaryRanges(int[] nums) {
        if(nums.Length == 0)
            return [];
            
        List<string> res = new();
        int ptr = nums[0];
        int startPtr = nums[0];
        int endPtr = nums[0];
        for(int i = 1; i < nums.Length; i++)
        {
            ptr++;
            if(nums[i] == ptr)
                endPtr++;
            else
            {
                res.Add(MakeRangeString(startPtr, endPtr));
                ptr = startPtr = endPtr = nums[i];
            }
        }
        res.Add(MakeRangeString(startPtr, endPtr)); //handle last range
        return res;
    }

    string MakeRangeString(int start, int end) {
        StringBuilder str = new();
        str.Append(start);
        if (start != end) {
            str.Append("->");
            str.Append(end);
        }
        return str.ToString();
    }
}