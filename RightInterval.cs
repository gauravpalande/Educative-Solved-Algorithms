using System;
using System.Collections.Generic;

public class Solution{
    public static int[] FindRightInterval (int[][] intervals)
    {
        int n = intervals.Length;
        int[] result = new int[n];
        Array.Fill(result, -1);

        MinHeap startHeap = new MinHeap();
        MinHeap endHeap = new MinHeap();

        for (int i = 0; i < n; i++)
        {
            startHeap.Insert((intervals[i][0], i));
            endHeap.Insert((intervals[i][1], i));
        }

        while (!endHeap.IsEmpty())
        {
            var (endValue, index) = endHeap.RemoveMin();

            while (!startHeap.IsEmpty() && startHeap.elements[0].num < endValue)
            {
                startHeap.RemoveMin();
            }

            if (!startHeap.IsEmpty())
            {
                result[index] = startHeap.elements[0].index;
            }
        }

        return result;
    }
}