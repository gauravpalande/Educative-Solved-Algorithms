using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {

    public int CountDays(int days, int[][] meetings) {
        
        int[] lookup = new int [days+1];
        
        foreach(var meeting in meetings)
        {
            for(int i = meeting[0]; i <= meeting[1]; i++)
            {
                lookup[i] = 1;
            }
        }
        
        return lookup.Skip(1).Count(val => val == 0);
    }
}