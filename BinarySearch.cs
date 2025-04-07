using System;
using System.Collections.Generic;

public class Solution{
    public static int BinarySearch(int[] nums, int target) 
    {
        // Initialize function variables
        int start = 0;
        int end = nums.Length - 1;
        
        //Loop till start crosses end 
        while(start <= end)
        {
        int mid = (start + end)/2;
        if(nums[mid] == target)
        {
            // target found
            return mid;
        }
        if(nums[mid] > target)
        {
            // reduce search space to lower half
            end = mid - 1;
        }
        else
        {
            // reduce search space to upper half
            start = mid+1;
        }
        }
        
        // target not found
        return -1;
    }
}