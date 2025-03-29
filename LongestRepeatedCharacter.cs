using System;

public class Solution
{
    public static int LongestRepeatingCharacterReplacement(string s, int k)
    {
        int stringLength = s.Length;
        int lengthOfMaxSubstring = 0;
        int start = 0;
        Dictionary<char, int> charFreq = new Dictionary<char, int>();
        int mostFreqChar = 0;

        for (int end = 0; end < stringLength; ++end)
        {
            char currentChar = s[end];

            if (charFreq.ContainsKey(currentChar))
                charFreq[currentChar]++;
            else
                charFreq[currentChar] = 1;

            mostFreqChar = Math.Max(mostFreqChar, charFreq[currentChar]);

            if (end - start + 1 - mostFreqChar > k)
            {
                charFreq[s[start]]--;
                start += 1;
            }

            lengthOfMaxSubstring = Math.Max(lengthOfMaxSubstring, end - start + 1);
        }

        return lengthOfMaxSubstring;
    }
}
