//https://leetcode.com/problems/intersection-of-two-arrays/

public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        HashSet<int> common = new HashSet<int>();
        foreach(int i in nums1)
            if(nums2.Contains(i))
                common.Add(i);
        
        return common.ToArray();
    }
}