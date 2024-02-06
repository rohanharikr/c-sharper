//https://leetcode.com/problems/majority-element/

public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary<int, int> map = new();
        foreach(int i in nums)
            map[i] = map.ContainsKey(i) ? (map[i] + 1) : 1;

        int[] majority = { 0, 0 };
        foreach(KeyValuePair<int, int> i in map)
        {
            if(i.Value > majority[1])
            {
                majority[0] = i.Key;
                majority[1] = i.Value;
            }
        }

        return majority[0];
    }
}