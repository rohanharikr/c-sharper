//https://leetcode.com/problems/unique-number-of-occurrences/

public class Solution {
    public bool UniqueOccurrences(int[] arr) {
        Dictionary<int, int> map = new();
        foreach(int i in arr)
            if(!map.ContainsKey(i))
                map[i] = 1;
            else
                map[i]++;
        
        HashSet<int> deduped = new HashSet<int>(map.Values);
        return deduped.Count == map.Count;
    }
}