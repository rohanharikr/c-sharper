//https://leetcode.com/problems/ransom-note/

public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        List<char> magazineArr = magazine.ToCharArray().ToList();
        foreach(char c in ransomNote)
        {
            if(!magazineArr.Contains(c))
                return false;

            magazineArr.Remove(c);
        }
        return true;
    }
}