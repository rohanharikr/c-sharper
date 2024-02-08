//https://leetcode.com/problems/string-matching-in-an-array/

public class Solution {
    public IList<string> StringMatching(string[] words) {
        HashSet<string> deduped = new();
        for(int i = 0; i < words.Length - 1; i++)
        {
            for(int j = i + 1; j < words.Length; j++)
            {
                if(words[j].Contains(words[i]))
                    deduped.Add(words[i]);
                else if(words[i].Contains(words[j]))
                    deduped.Add(words[j]);
            }
        }
        return deduped.ToList();
    }
}