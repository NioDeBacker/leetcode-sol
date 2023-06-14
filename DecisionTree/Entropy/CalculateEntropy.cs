public class Solution {
    public double CalculateEntropy(int[] input) {
        var dictionary = new Dictionary<int, int>();

        foreach (var number in input)
        {
            if (dictionary.ContainsKey(number))
                dictionary[number]++;
            else
                dictionary.Add(number, 1);
        }
        
        double result = 0;
        foreach(var entry in dictionary)
        {
            double p = (double)entry.Value/input.Length;
            result += (- p * (Math.Log(p, 2)));
        }
        
        return result;

    }
}