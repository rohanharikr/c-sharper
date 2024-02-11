//https://leetcode.com/problems/product-of-array-except-self/

public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;
        int[] products = new int[n];

        int leftProduct = 1;
        for(int i = 0; i < n; i++)
        {
            products[i] = leftProduct;
            leftProduct *= nums[i];
        }

        int rightProduct = 1;
        for(int i = n - 1; i >= 0; i--)
        {
            products[i] *= rightProduct;
            rightProduct *= nums[i];
        }

        return products;
    }
}
