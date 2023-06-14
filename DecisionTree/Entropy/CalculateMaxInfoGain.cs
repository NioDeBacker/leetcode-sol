using System;
using System.Collections.Generic;

class Solution
{
    public double CalEntropy(List<string> species)
    {
        Dictionary<string, int> shown = new Dictionary<string, int>();
        double total = species.Count;

        foreach (string specie in species)
        {
            if (shown.ContainsKey(specie))
                shown[specie]++;
            else
                shown[specie] = 1;
        }

        double entropy = 0.0;
        foreach (var n in shown)
        {
            double p = n.Value / total;
            entropy -= p * Math.Log(p) / Math.Log(2.0);
        }

        return entropy;
    }

    public double CalculateMaxInfoGain(double[] petal_length, string[] species)
    {
        // Avoid edge case
        if (petal_length.Length == 0 || species.Length == 0)
            return 0.0;

        int s = petal_length.Length;
        double all_entropy = CalEntropy(new List<string>(species));
        double information_gain = 0.0;

        // Iterate all possible splits
        for (int i = 0; i < s; i++)
        {
            // Split list
            double split = petal_length[i];
            List<string> l1 = new List<string>();
            List<string> l2 = new List<string>();

            for (int j = 0; j < s; j++)
            {
                if (petal_length[j] < split)
                    l1.Add(species[j]);
                else
                    l2.Add(species[j]);
            }

            // Calculate information gain
            double l1_entropy = CalEntropy(l1);
            double l2_entropy = CalEntropy(l2);
            double p1 = (double)l1.Count / s;
            double p2 = (double)l2.Count / s;
            information_gain = Math.Max(information_gain, all_entropy - l1_entropy * p1 - l2_entropy * p2);
        }

        return information_gain;
    }
}
