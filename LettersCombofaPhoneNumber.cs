using System;
using System.Collections.Generic;
using System.Text;

public class Solution{
    public void Backtrack(int index, StringBuilder path, string digits, Dictionary<char, string[]> letters, List<string> combinations)
    {
        if (path.Length == digits.Length)
        {
            combinations.Add(path.ToString());
            return;
        }

        char digit = digits[index];
        string[] possibleLetters = letters[digit];
        foreach (string letter in possibleLetters)
        {
            path.Append(letter);
            Backtrack(index + 1, path, digits, letters, combinations);
            path.Length = path.Length - 1;
        }
    }

    public List<string> LetterCombinations(string digits)
    {
        List<string> combinations = new List<string>();
        if (digits.Length == 0)
        {
            return combinations;
        }

        Dictionary<char, string[]> digitsMapping = new Dictionary<char, string[]>()
        {
            {'1', new string[]{""}},
            {'2', new string[]{"a", "b", "c"}},
            {'3', new string[]{"d", "e", "f"}},
            {'4', new string[]{"g", "h", "i"}},
            {'5', new string[]{"j", "k", "l"}},
            {'6', new string[]{"m", "n", "o"}},
            {'7', new string[]{"p", "q", "r", "s"}},
            {'8', new string[]{"t", "u", "v"}},
            {'9', new string[]{"w", "x", "y", "z"}}
        };

        Backtrack(0, new StringBuilder(), digits, digitsMapping, combinations);

        return combinations;
    }
}