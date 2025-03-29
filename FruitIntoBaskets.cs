using System;

public class Solution {
    public int TotalFruit(int[] fruits) {
        
        var baskets = new Dictionary<int, int>();
        int start = 0;
        int n = fruits.Length;
        int windowLength = 0;
        
        for(int end = 0; end < n; end++)
        {
            if(!baskets.ContainsKey(fruits[end]))
            {
                baskets.Add(fruits[end], 1);
            }
            else
            {
                baskets[fruits[end]]++;
            }
            
            while(baskets.Where(x=>x.Value > 0).Count() > 2)
            {
                baskets[fruits[start]]--;
                start++;
            }
            
            windowLength = Math.Max(windowLength, end-start+1);
        }
        
        return windowLength;
    }
}