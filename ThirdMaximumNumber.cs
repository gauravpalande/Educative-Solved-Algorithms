using System;
public class Solution
{
    public static int ThirdMax(int[] nums) 
    {
        // Initialize function variables
        var lookup = new HashSet<int>();
        var maxHeap = new PriorityQueue<int, int>();
        
        // Fill lookup
        foreach(int num in nums)
        {
            if(!lookup.Contains(num))
            {
                lookup.Add(num);
            }
        }
        
        // Fill max heap
        foreach(int num in lookup)
        {
            maxHeap.Enqueue(num, num*-1);
        }
        
        // display 3rd maximum
        int k = 2;
        int current = -1;
        int maximum = maxHeap.Dequeue();
        
        while(k > 0)
        {
            if(maxHeap.Count == 0)
            {
                return maximum;
            }
            else
            {
                current = maxHeap.Dequeue();
                k--;
            }
        }
        
        return current;
    }
}