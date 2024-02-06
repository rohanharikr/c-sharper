//https://leetcode.com/problems/container-with-most-water/

public class Solution {
    public int MaxArea(int[] height) {
        int maxArea = 0;
        int left = 0;
        int right = height.Length - 1;
        while(left < right)
        {
            int h = Math.Min(height[left], height[right]);
            int w = right - left;
            maxArea = Math.Max(maxArea, h * w);
            if(height[left] < height[right])
                left++;
            else
                right--;
        }
        return maxArea;
    }
}