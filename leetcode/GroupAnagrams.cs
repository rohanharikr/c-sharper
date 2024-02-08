//https://leetcode.com/problems/group-anagrams/

public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> map = new ();
        foreach(string s in strs)
        {
            char[] strArr = s.ToCharArray();
            Array.Sort(strArr);
            string sorted = new String(strArr);

            if(map.ContainsKey(sorted))
                map[sorted].Add(s);
            else
                map[sorted] = new List<string>() { s };
        }
        
        List<IList<string>> res = new();
        foreach(IList<string> group in map.Values)
            res.Add(group);

        return res;
    }
}