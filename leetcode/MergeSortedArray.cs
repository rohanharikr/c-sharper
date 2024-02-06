//https://leetcode.com/problems/merge-sorted-array/

public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        for(int i = 0; i < nums2.Length; i++)
            nums1[nums1.Length - 1 -i] = nums2[i];
        
        Array.Sort(nums1);
    }
}