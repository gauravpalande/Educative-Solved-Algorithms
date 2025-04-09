using System;
public class Solution
{
    public IList<string> LetterCasePermutation(string s)
    {
        var output = new List<string>();
        DFS(s.ToCharArray(), 0, output);
        return output;
    }

    private void DFS(char[] chars, int index, List<string> output)
    {
        if (index == chars.Length)
        {
            output.Add(new string(chars));
            return;
        }

        // Always continue with the current character
        DFS(chars, index + 1, output);

        // If it's a letter, flip the case and recurse again
        if (char.IsLetter(chars[index]))
        {
            chars[index] = char.IsUpper(chars[index]) 
                ? char.ToLower(chars[index]) 
                : char.ToUpper(chars[index]);

            DFS(chars, index + 1, output);

            // Backtrack the change
            chars[index] = char.IsUpper(chars[index]) 
                ? char.ToLower(chars[index]) 
                : char.ToUpper(chars[index]);
        }
    }
}