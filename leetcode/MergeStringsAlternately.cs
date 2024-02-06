//https://leetcode.com/problems/merge-strings-alternately/

public class Solution {
    public string MergeAlternately(string word1, string word2) {
        string str = "";
        for(int i = 0; i < word1.Length + word2.Length; i++)
        {
            if(i < word1.Length)
                str += word1[i];
            if(i < word2.Length)
                str += word2[i];
        }
        return str;
    }
}