//https://leetcode.com/problems/find-nearest-point-that-has-the-same-x-or-y-coordinate/

public class Solution {
    public int NearestValidPoint(int x, int y, int[][] points) {
        int smallestDistance = Int32.MaxValue;
        int index = -1;
        for(int i = 0; i < points.Length; i++)
        {
            if(points[i][0] != x && points[i][1] != y)
                continue;
            
            int distance = Math.Abs(x - points[i][0]) + Math.Abs(y - points[i][1]);
            if(distance < smallestDistance)
            {
                smallestDistance = distance;
                index = i;
            }            
        }
        return index;
    }
}