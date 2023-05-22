public class Solution {
    static Dictionary<Char, int> Symbols = new Dictionary<Char, int>{
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000},
    };
    public int RomanToInt(string s) {
        var total = 0;
       for(var i = 0; i < s.Length; i ++) {
           var value = Symbols[s[i]];
           var nextValue = 0;
           if (i != s.Length - 1) {
            nextValue = Symbols[s[i+1]];
           }
            if (nextValue > value) {
                  total -= value;
            } else {
                total += value;
            }
       }
       return total;
    }
}
