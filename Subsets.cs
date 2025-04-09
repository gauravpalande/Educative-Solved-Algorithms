using System;
using System.Collections.Generic;

public class Solution {
  	public static IList<IList<int>> FindAllSubsets(int[] nums) 
  	{
    IList<IList<int>> output = new List<IList<int>>();
    output.Add(new List<int>()); // start with the empty set
    
    foreach (int num in nums)
    {
        int size = output.Count;
        for (int i = 0; i < size; i++)
        {
            var newSubset = new List<int>(output[i]); // copy current subset
            newSubset.Add(num); // add current number
            output.Add(newSubset); // add new subset to output
        }
    }
    
    return output;
}
}
