public class Solution {
    public IList<string> FizzBuzz(int n) {
        IList<string> solution = new List<string> {"1"};
        for (int i = 2; i<=n; i ++) {
            string iOutput = "";
            int iThree = i % 3;
            int iFive = i % 5;
            if (iThree == 0) {
                iOutput += "Fizz";
            }
            if (iFive == 0) {
                iOutput += "Buzz";
            }
            if (iThree != 0 && iFive != 0) {
                iOutput = i.ToString();
            }
            solution.Add(iOutput);
        }
        return solution;
    }
}
