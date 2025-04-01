using System;

public class Solution
{
    public static int[][] MergeIntervals(int[][] intervals)
    {
        var output = new List<int[]>();
        int n = intervals.Length;
        
        if( n == 0)
        {
            return output.ToArray();
        }
        
        int outputIndex = 0;
        int intervalIndex = 0;
        
        output.Add(intervals[intervalIndex]);
        intervalIndex++;
        
        while(intervalIndex < n)
        {
            if(intervals[intervalIndex][0] <= output[output.Count - 1][1])
            {
                output[output.Count-1][1] = Math.Max(intervals[intervalIndex][1], output[output.Count - 1][1]);
                intervalIndex++;
            }
            else{
                output.Add(intervals[intervalIndex++]);
            }
        }
        
        return output.ToArray();
    }
}