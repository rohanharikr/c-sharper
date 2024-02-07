//https://leetcode.com/problems/element-appearing-more-than-25-in-sorted-array/

public class Solution {
    public int FindSpecialInteger(int[] arr) {
        int count = 0;
        int current = arr[0];
        int countNeeded = arr.Length / 4;
        foreach(int i in arr)
        {
            if(i == current)
                count++;

            if(count > countNeeded)
                break;

            if(i != current)
            {
                current = i;
                count = 1;
            }
        }

        return current;
    }
}