using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution{
    public static IList<string> GenerateCombinations(int n) 
    {
        var output = new List<string>();
        if (n == 0) return output;

        Combinations(n, n, new StringBuilder(), output);
        return output;
    }

    public static void Combinations(int open, int close, StringBuilder path, List<string> output) {
        if (open == 0 && close == 0) {
            output.Add(path.ToString());
            return;
        }

        if (open > 0) {
            path.Append('(');
            Combinations(open - 1, close, path, output);
            path.Length--; // backtrack
        }

        if (close > open) {
            path.Append(')');
            Combinations(open, close - 1, path, output);
            path.Length--; // backtrack
        }
    }
}