//https://leetcode.com/problems/three-consecutive-odds

public class Solution {
    public bool ThreeConsecutiveOdds(int[] arr) {
        int counter = 0;
        foreach(int i in arr)
        {
            if(i % 2 != 0)
                counter++;
            else if(counter >= 3)
                return true;
            else
                counter = 0;
        }
        return counter >= 3;
    }
}