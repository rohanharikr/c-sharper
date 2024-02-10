//https://leetcode.com/problems/reverse-vowels-of-a-string/

public class Solution {
    public string ReverseVowels(string s) {
        const string vowels = "aeiou";
        List<char> result = s.Where(i => vowels.Contains(char.ToLower(i))).Reverse().ToList();
        List<int> indexes = Enumerable.Range(0, s.Length)
            .Where(i => vowels.Contains(char.ToLower(s[i])))
            .ToList();
        char[] res = s.ToCharArray();
        for (int i = 0; i < indexes.Count; i++) {
            res[indexes[i]] = result[i];
        }
        return new String(res);
    }
}