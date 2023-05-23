public class Solution {
    public int[] KWeakestRows(int[][] mat, int k) {
        return mat
                .Select((row, i) => new { score = row.Sum(), index = i })
                .OrderBy(r => r.score)
                .Select(r => r.index)
                .Take(k)
                .ToArray();
    }
}