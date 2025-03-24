using System;

public class Solution {
    public static bool ValidWordAbbreviation(string word, string abbr) {
        int wordIndex = 0, abbrIndex = 0;

        while (abbrIndex < abbr.Length) {
            if (char.IsDigit(abbr[abbrIndex])) {
                if (abbr[abbrIndex] == '0') {
                    return false;
                }
                int num = 0;

                while (abbrIndex < abbr.Length && char.IsDigit(abbr[abbrIndex])) {
                    num = num * 10 + (abbr[abbrIndex] - '0');
                    abbrIndex++;
                }
                wordIndex += num;
            } else {
                if (wordIndex >= word.Length || word[wordIndex]!= abbr[abbrIndex]) {
                    return false;
                }
                wordIndex++;
                abbrIndex++;
            }
        }

        return wordIndex == word.Length && abbrIndex == abbr.Length;
    }
}