//https://leetcode.com/problems/single-number-ii/

public class Solution {
    public int SingleNumber(int[] nums) {
        Dictionary<int, int> map = new Dictionary<int, int>();
        foreach(int i in nums)
            map[i] = map.ContainsKey(i) ? (map[i] + 1) : 1;
        int min = 0;
        foreach(KeyValuePair<int, int> entry in map)
            if(entry.Value == 1)
                min = entry.Key;

        return min;
    }
}