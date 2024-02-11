//https://leetcode.com/problems/count-primes/

public class Solution {
    public int CountPrimes(int n) {
        if(n <= 2)
            return 0;

        bool[] primes = new bool[n];
        for(int i = 2; i < Math.Sqrt(n); i++)
        {
            if(primes[i])
                continue;
            
            for(int j = i * i; j < n; j += i)
                primes[j] = true;
        }

        return primes.Count(p => !p) - 2;
    }
}