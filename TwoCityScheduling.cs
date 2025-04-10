using System;
using System.Collections.Generic;

public class Solution {
    public static int TwoCityScheduling(int[][] costs) 
    {
        int totalCost = 0;
        int n = costs.Length;
        
        costs = costs.OrderBy(x=> x[0] - x[1]).ToArray();
        
        for(int i = 0; i < n; i++)
        {
            if(i < n/2)
            {
                totalCost += costs[i][0];
            }
            else
            {
                totalCost += costs[i][1];
            }
        }
        
        return totalCost;
    }
}