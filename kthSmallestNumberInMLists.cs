using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
  public static int KSmallestNumber(List<List<int>> lists, int k) 
  {
    var minHeap = new MinHeap<int[]>(Comparer<int[]>.Create((a,b) => (a[0].CompareTo(b[0]))));
    
    for(int i = 0; i < lists.Count; i++)
    {
      if(lists[i].Count > 0)
      minHeap.Add((new int[] {lists[i][0], i, 0}));
    }
    
    int output = 0;
    while(k > 0 && minHeap.Count > 0)
    {
      k--;
      var smallest = minHeap.Remove();
      output = smallest[0];
      
      if(smallest[2] + 1 < lists[smallest[1]].Count)
      {
        minHeap.Add(new int[] {lists[smallest[1]][smallest[2] + 1], smallest[1], smallest[2] + 1});
      }
    }
    
    return output;
  }
}