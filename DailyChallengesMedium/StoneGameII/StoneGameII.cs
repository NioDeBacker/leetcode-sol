public class Solution {
    public int StoneGameII(int[] piles) {
        int[,,] dp = new int[2, piles.Length + 1, piles.Length + 1];

        for (int p = 0; p < 2; ++p)
            for (int i = 0; i <= piles.Length; ++i)
                for (int m = 0; m <= piles.Length; ++m)
                    dp[p, i, m] = -1;

        return f(piles, dp, 0, 0, 1);
    }

    private int f(int[] piles, int[,,] dp, int p, int i, int m)
    {
        if (i == piles.Length)
            return 0;
        
        if (dp[p, i, m] != -1)
            return dp[p, i, m];
        
        int res = p == 1 ? 1000000 : -1, s = 0;

        for (int x = 1; x <= Math.Min(2 * m, piles.Length - i); x++)
        {
            s += piles[i + x - 1];

            if (p == 0)
                res = Math.Max(res, s + f(piles, dp, 1, i + x, Math.Max(m, x)));            
            else
                res = Math.Min(res, f(piles, dp, 0, i + x, Math.Max(m, x)));
        }
        
        return dp[p, i, m] = res;
    }
}