//https://leetcode.com/problems/compare-version-numbers/

public class Solution {
    public int CompareVersion(string version1, string version2) {
        List<int> v1 = version1.Split(".").Select(int.Parse).ToList();
        List<int> v2 = version2.Split(".").Select(int.Parse).ToList();
        
        int maxLength = Math.Max(version1.Length, version2.Length);
        for(int i = 0; i < maxLength; i++)
        {
            int num1 = i < v1.Count ? v1[i] : 0;
            int num2 = i < v2.Count ? v2[i] : 0;

            if(num1 < num2)
                return -1;
            else if(num1 > num2)
                return 1;
        }
        return 0;
    }
}