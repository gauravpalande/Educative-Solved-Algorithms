using System;
using System.Collections.Generic;

public class Solution{
   public static List<Point> KClosest(Point[] points, int k) 
   {
       // declare function variables
       double distance = 0;
       var minHeap = new PriorityQueue<Point, double>();
       
       // fill minHeap with all points
       foreach(var p in points)
       {
           distance = Math.Sqrt((p.x)*(p.x) + (p.y)*p.y);
           minHeap.Enqueue(p, distance);
       }
       var output = new List<Point>();
       // get min k points
       while(k > 0)
       {
           output.Add(minHeap.Dequeue());
           k--;
       }
       
       return output;
   }
}