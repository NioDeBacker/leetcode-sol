public class Solution
{
    public string StoneGameIII(int[] stoneValue)
    {
        var n = stoneValue.Length;
        var dp = new int[3];

        for (var i = n - 1; i >= 0; --i)
        {
            var takeOne = stoneValue[i] - dp[(i + 1) % 3];
            var takeTwo = i + 1 < n ? stoneValue[i] + stoneValue[i + 1] - dp[(i + 2) % 3] : int.MinValue;
            var takeThree = i + 2 < n ? stoneValue[i] + stoneValue[i + 1] + stoneValue[i + 2] - dp[(i + 3) % 3] : int.MinValue;

            dp[i % 3] = Math.Max(takeOne, Math.Max(takeTwo, takeThree));
        }

        return dp[0] switch
        {
            > 0 => "Alice",
            < 0 => "Bob",
            _ => "Tie"
        };
    }
}