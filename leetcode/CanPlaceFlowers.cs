//https://leetcode.com/problems/can-place-flowers/

public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        if(n == 0)
            return true;

        if (flowerbed.Length == 1)
            return flowerbed[0] == 0;
        
        int placed = 0;
        for(int i = 0; i < flowerbed.Length; i++)
        {
            if(flowerbed[i] != 0)
                continue;

            bool isFirst = i == 0;
            bool isLast = i == flowerbed.Length - 1;
            bool canPlantFirst = isFirst && flowerbed[i + 1] == 0;
            bool canPlantLast = isLast && flowerbed[i - 1] == 0;
            bool canPlant = !isFirst && !isLast && flowerbed[i - 1] == 0 && flowerbed[i + 1] == 0;

            if(canPlantFirst || canPlantLast || canPlant)
            {
                flowerbed[i] = 1;
                placed++;
            }
        }

        return placed >= n;
    }
}