using System;
using System.Collections.Generic;

public class Solution{
    public static string SwapChar(string word, int i, int j)
    {
        char[] SwapIndex = word.ToCharArray();
        char temp = SwapIndex[i];
        SwapIndex[i] = SwapIndex[j];
        SwapIndex[j] = temp;

        return new string(SwapIndex);
    }

    public static void PermuteStringRec(string word, int CurrentIndex, IList<string> results)
    {
        if (CurrentIndex == word.Length - 1)
        {
            results.Add(word);
            return;
        }

        for (int index = CurrentIndex; index < word.Length; index++)
        {
            string SwappedStr = SwapChar(word, CurrentIndex, index);
            PermuteStringRec(SwappedStr, CurrentIndex + 1, results);
        }
    }

    public static IList<string> PermuteWord(string word)
    {
        IList<string> results = new List<string>();
        PermuteStringRec(word, 0, results);
        return results;
    }
}