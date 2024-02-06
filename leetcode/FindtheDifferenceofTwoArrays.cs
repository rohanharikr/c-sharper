//https://leetcode.com/problems/find-the-difference-of-two-arrays/

public class Solution {
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2) {
        IList<IList<int>> deduped = new List<IList<int>>()
        {
            new List<int>(),
            new List<int>()
        };
        foreach(int num in nums1)
            if(!nums2.Contains(num) && !deduped[0].Contains(num))
                deduped[0].Add(num);
        foreach(int num in nums2)
            if(!nums1.Contains(num) && !deduped[1].Contains(num))
                deduped[1].Add(num);

        return deduped;
    }
}