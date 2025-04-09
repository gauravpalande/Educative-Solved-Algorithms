using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public static int NumTilePossibilities(string tiles)
    {
        var freq = new Dictionary<char, int>();
        foreach (var c in tiles)
        {
            if (!freq.ContainsKey(c)) freq[c] = 0;
            freq[c]++;
        }

        return DFS(freq);
    }

    private static int DFS(Dictionary<char, int> freq)
    {
        int count = 0;
        foreach (var key in freq.Keys)
        {
            if (freq[key] == 0) continue;

            count++;
            freq[key]--;
            count += DFS(freq); // continue building sequences
            freq[key]++; // backtrack
        }
        return count;
    }
}