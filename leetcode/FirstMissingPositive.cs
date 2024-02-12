//https://leetcode.com/problems/first-missing-positive/

public class Solution {
    public int FirstMissingPositive(int[] nums) {
        int[] arr = nums.Distinct().ToArray();
        Array.Sort(arr);
        int n = 1;
        for(int i = 0; i < arr.Length; i++)
        {
            if(arr[i] <= 0)
                continue;
            
            if(arr[i] == n)
                n++;
            else
                break;
        }
        return n;
    }
}