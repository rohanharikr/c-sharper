//https://leetcode.com/problems/guess-number-higher-or-lower/

/** 
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is higher than the picked number
 *			      1 if num is lower than the picked number
 *               otherwise return 0
 * int guess(int num);
 */

public class Solution : GuessGame {
    public int GuessNumber(int n) {
        int l = 1, r = n;
        while(l <= r)
        {
            int mid = l + (r - l) / 2;
            int result = guess(mid);
            if(result == 0)
                return mid;
            else if(result == -1)
                r = mid - 1;
            else
                l = mid + 1;
        }

        //Code never reaches here
        return -1; 
    }
}