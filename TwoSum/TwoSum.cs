public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] answer = new int[2];
        if (nums.Length > 2) {
            for (int i = 0; i < nums.Length; i++) {
                answer[0] = i;
                for (int j = i + 1; j < nums.Length; j++) {
                    if (nums[j] + nums[i] == target) {
                        answer[1] = j;
                        return answer;
                    }
                }
            }
        }
        answer[0] = 0;
        answer[1] = 1;
        return answer;
    }
}