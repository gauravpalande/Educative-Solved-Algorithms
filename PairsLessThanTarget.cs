using System;
using System.Collections.Generic;

public class Solution{
    public static int CountPairs (IList<int> nums, int target) {
        List<int> list = nums.ToList();
        int count = 0;
        list.Sort();
        
        int i = 0;
        int j = list.Count - 1;
        
        while(i < j)
        {
            if(list[i] + list[j] < target)
            {
                count += (j-i);
                i++;
            }
            else
            {
                j--;
            }
        }
        
        return count;
    }
}
