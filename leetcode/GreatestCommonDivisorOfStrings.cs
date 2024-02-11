//https://leetcode.com/problems/greatest-common-divisor-of-strings/

public class Solution {
    public string GcdOfStrings(string str1, string str2) {
        string str = str1.Length <= str2.Length ? str1 : str2;
        string shortest = "";

        for(int i = str.Length; i >= 0; i--)
        {
            shortest = str.Substring(0, i);
            if(shortest.Length == 0)
                break;

            if(IsDivisible(str1, shortest) && IsDivisible(str2, shortest))
                return shortest;
        }

        return "";
    }

    private bool IsDivisible(string str, string divisor) {
        if(str.Length % divisor.Length != 0)
            return false;

        for(int i = 0; i < str.Length; i++) {
            if(str[i] != divisor[i % divisor.Length])
                return false;
        }
        return true;
    }
}