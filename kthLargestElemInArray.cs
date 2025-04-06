using System;
using System.Collections.Generic;

public class Solution{
   public static int FindKthLargest(int[] nums, int k) 
   {
       // initialize function variables
       var maxHeap = new PriorityQueue<int, int>();
       
       // fill max heap
       foreach(int num in nums)
       {
           maxHeap.Enqueue(num, num*-1);
       }
       
       // loop till k elements
       int current = 0;
       while(k > 0)
       {
           current = maxHeap.Dequeue();
           k--;
       }
       
       // output
       return current;
   }
}