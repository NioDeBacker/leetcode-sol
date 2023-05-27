public class Solution {
    public int MaximumWealth(int[][] accounts) {
        int maxVal = 0;
        for (int i = 0; i < accounts.Length; i++) {
            int sum  = accounts[i].Sum();
            if (sum >= maxVal) {
                maxVal = sum;
            }
        }
        return maxVal;
    }
}
