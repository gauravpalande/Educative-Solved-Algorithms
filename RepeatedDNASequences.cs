using System;
using System.Collections.Generic;

public class Solution
{
    public static IList<string> FindRepeatedDnaSequences(string s)
    {
        int n = s.Length;
        string sub = string.Empty;
        var lookup = new HashSet<string>();
        List<string> output = new List<string>();
        for(int i = 0; i < n-10; i++)
        {
            sub = s.Substring(i, 10);
            if(lookup.Contains(sub))
            {
                output.Add(sub);
            }
            else{
                lookup.Add(sub);
            }
        }
        
        return output.Distinct().ToList();
    }
}