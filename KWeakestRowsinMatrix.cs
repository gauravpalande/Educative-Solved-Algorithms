using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public static int[] FindKWeakestRows(int[][] matrix, int k)
    {
        int rows = matrix.Length;
        int cols = matrix[0].Length;
        var minHeap = new List<(int Strength, int Index)>();
        
        for(int i = 0; i < rows; i++)
        {
            int left = 0;
            int right = cols;
            
            while(left < right)
            {
                int mid = left+(right - left)/2;
                
                if(matrix[i][mid] == 1)
                {
                    left = mid+1;
                }
                else
                {
                    right = mid;
                }
            }
            
            minHeap.Add((left, i));
        }
            
        return minHeap.OrderBy(x => x.Strength).ThenBy(x => x.Index).Take(k).Select(x => x.Index).ToArray();
    }
}
