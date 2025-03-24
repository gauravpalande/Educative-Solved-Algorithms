using System;

public class Solution {
    public static string ReverseWords(string sentence) {
        var resultList = new List<string>();
        // trim the input
        sentence = sentence.Trim();
        
        // split the string into words and store it in the result object
        resultList = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
        
        // initialize iterators
        int i = 0;
        int j = resultList.Count -1;
        string temp = string.Empty;
        
        // start swapping
        while(i < j)
        {
            temp = resultList[i];
            resultList[i] = resultList[j];
            resultList[j] = temp;
            i++;
            j--;
        }
        
        // Join all in a sentence
        return string.Join(" ", resultList);
    }
}
