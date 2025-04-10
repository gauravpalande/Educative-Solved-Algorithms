using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution
{
    public static string LargestPalindrome(string num)
    {
        var freqLookup = new Dictionary<int, int>();
        foreach (char c in num)
        {
            int digit = c - '0';
            if (!freqLookup.ContainsKey(digit))
                freqLookup[digit] = 0;
            freqLookup[digit]++;
        }

        var sorted = freqLookup.OrderByDescending(x => x.Key).ToList();
        var sb = new StringBuilder();
        var sbEnd = new StringBuilder();
        string mid = "";

        foreach (var kvp in sorted)
        {
            int digit = kvp.Key;
            int freq = kvp.Value;

            // Special case: skip leading 0s unless we already have something in sb
            if (digit == 0 && sb.Length == 0)
                continue;

            while (freq >= 2)
            {
                sb.Append(digit);
                sbEnd.Insert(0, digit);
                freq -= 2;
            }

            if (freq == 1 && mid == "")
            {
                mid = digit.ToString();
            }
        }

        // Handle the edge case: if no digits were added due to all being 0s
        if (sb.Length == 0 && mid == "")
        {
            if (freqLookup.ContainsKey(0) && freqLookup[0] > 0)
                return "0";
        }

        return sb.ToString() + mid + sbEnd.ToString();
    }
}
