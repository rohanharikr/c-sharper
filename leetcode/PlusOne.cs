//https://leetcode.com/problems/plus-one/

public class Solution {
    public int[] PlusOne(int[] digits) {
        for(int i = digits.Length - 1; i >= 0; i--)
        {
            if(digits[i] < 9)
            {
                digits[i] += 1;
                return digits;
            }

            digits[i] = 0;
        }
        List<int> res = digits.ToList();
        res.Insert(0, 1);
        return res.ToArray();
    }
}