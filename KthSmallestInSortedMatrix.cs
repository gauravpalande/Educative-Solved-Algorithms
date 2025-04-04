using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public static int KthSmallestElement(int[][] matrix, int k) 
    {
        var minHeap = new PriorityQueue<int[], int>(); // Use built-in min-heap
        int m = matrix.Length;
        
        for(int i = 0; i < m; i++)
        {
            // Each entry is: [value, row, col]
            minHeap.Enqueue(new int[] {matrix[i][0], i, 0}, matrix[i][0]);
        }

        int[] smallest = null;

        while(k > 0 && minHeap.Count > 0)
        {
            smallest = minHeap.Dequeue(); // [value, row, col]
            int row = smallest[1];
            int col = smallest[2];

            // Only push the next element in the row if it exists
            if (col + 1 < matrix[row].Length)
            {
                int nextVal = matrix[row][col + 1];
                minHeap.Enqueue(new int[] {nextVal, row, col + 1}, nextVal);
            }
            k--;
        }

        return smallest[0];
    }
}
