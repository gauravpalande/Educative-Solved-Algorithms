using System;
using System.Collections.Generic;

public class Solution {
    public static int[] KthSmallestPrimeFraction(int[] arr, int k) 
    {
        int n = arr.Length;
        double fraction = 0.0;
        var minHeap = new PriorityQueue<int[], double>();
        
        for(int j = 0; j < n; j++)
        {
            fraction = (double)arr[0]/arr[j];
            minHeap.Enqueue(new int [] {0, j}, fraction);
        }
        
        int[] smallest = new int[2];
        while(k > 0)
        {
            k--;
            smallest = minHeap.Dequeue();
            fraction = (double)arr[smallest[0] + 1]/arr[smallest[1]];
            minHeap.Enqueue(new int[] {smallest[0]+1, smallest[1]}, fraction);
        }
        
        return new int[] {arr[smallest[0]], arr[smallest[1]]};
    }
}