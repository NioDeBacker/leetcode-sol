public class Solution {
    public int[] RunningSum(int[] nums) {
        int c = 0;
        return nums.Select(num => c += num).ToArray();
    }
}
