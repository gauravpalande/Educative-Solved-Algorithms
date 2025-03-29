using System;

public class Solution
{
    public static int FindLongestSubstring(string str)
    {
        if (str.Length == 0)
        {
            return 0;
        }

        int n = str.Length;
        int windowStart = 0, longest = 0, windowLength = 0, i = 0;

        Dictionary<char, int> lastSeenAt = new Dictionary<char, int>();

        for (i = 0; i < n; i++)
        {
            if (!lastSeenAt.ContainsKey(str[i]))
            {
                lastSeenAt[str[i]] = i;
            }
            else
            {
                if (lastSeenAt[str[i]] >= windowStart)
                {
                    windowLength = i - windowStart;
                    if (longest < windowLength)
                    {
                        longest = windowLength;
                    }

                    windowStart = lastSeenAt[str[i]] + 1;
                }

                lastSeenAt[str[i]] = i;
            }
        }

        if (longest < i - windowStart)
        {
            longest = i - windowStart;
        }

        return longest;
    }
}