using System;

public class Solution{
    public static int ConnectSticks (int[] sticks) {
      
        MinHeap<int> heap = new MinHeap<int>((a,b) => a.CompareTo(b));
        
        foreach(var stick in sticks)
        {
            heap.Enqueue(stick);
        }
        
        int totalCost = 0;
        
        while(heap.Count > 1)
        {
            var shortest = heap.Dequeue();
            var shorter = heap.Dequeue();
            
            var cost = shortest+shorter;
            totalCost+= cost;
            heap.Enqueue(cost);
        }
        
        return totalCost;
    }
}