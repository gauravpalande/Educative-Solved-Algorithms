using System;

public class Solution{
    public static int FindContentChildren(int[] greedFactors, int[] cookieSizes) {
        {
            // Initialize function variables
            int counter = 0;
            int i = 0;
            int j = 0;
            int n = greedFactors.Length;
            int m = cookieSizes.Length;
            if(n == 0 || m == 0)
                return counter;
            
            // Sort both arrays
            Array.Sort(greedFactors);
            Array.Sort(cookieSizes);
            
            // loop through arrays and increment counter if greed is satisfied
            while(i < n && j < m)
            {
                if(greedFactors[i] <= cookieSizes[j])
                {
                    i++;
                    j++;
                    counter++;
                }
                else
                {
                    j++;
                }
            }
            
            return counter;
        }
    }
}