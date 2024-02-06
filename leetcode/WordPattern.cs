//https://leetcode.com/problems/word-pattern/

public class Solution {
    public bool WordPattern(string pattern, string s) {
       Dictionary<string, char> map = new Dictionary<string, char>();
       string[] arr = s.Split(" ");
       
       if(pattern.Length != arr.Length)
        return false;

       for(int i = 0; i < arr.Length; i++)
       {
            if(!map.ContainsKey(arr[i]) && !map.ContainsValue(pattern[i]))
            {
                map.Add(arr[i], pattern[i]);
                continue;
            }

            if(!map.ContainsKey(arr[i]))
                return false;

            if(pattern[i] != map[arr[i]])
                return false;
       }

       return true;
    }
}