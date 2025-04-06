using System;
using System.Collections.Generic;

public class Solution{
    public static int[] TopKFrequent(int[] arr, int k) 
    {
        // Initialize function variables
        var freq = new Dictionary<int, int>();
        var maxHeap = new PriorityQueue<int, int>();
        
        // fill frequency hash
        foreach(int num in arr)
        {
            if(!freq.ContainsKey(num))
            {
                freq[num] = 1;
            }
            else
            {
                freq[num]++;
            }
        }
        
        // fill Max Heap
        foreach(var kvp in freq)
        {
            maxHeap.Enqueue(kvp.Key, kvp.Value*-1);
        }
        
        // fill output
        int[] output = new int[k];
        while(k > 0)
        {
            output[k-1] = maxHeap.Dequeue();
            k--;
        }
        
        return output;
    }
}