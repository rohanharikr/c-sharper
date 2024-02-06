//https://leetcode.com/problems/find-the-index-of-the-first-occurrence-in-a-string/

public class Solution {
    public int StrStr(string haystack, string needle) {
        for(int i = 0; i < haystack.Length; i++)
        {
            if(haystack.Length - i < needle.Length)
                break;

            if(haystack[i] == needle[0])
            {
                int count = 1;
                while(count < needle.Length)
                {
                    if(haystack[i + count] != needle[count])
                        break;

                    count++;
                }

                if(count == needle.Length)
                    return i;
            }
        }

        return -1;
    }
}