using System;
using System.Linq;

public class Solution {
    public static int MaxFrequency(int[] nums, int k) {
        
        int n = nums.Length;
        Array.Sort(nums);
        int start = 0;
        int end = 0;
        int sum = 0;
        int maxWindow = 0;
        
        for(end = 0; end < n; end++)
        {
            sum += nums[end];
            
            if(sum >= nums[end] * (end-start+1) - k)
            {
                maxWindow = Math.Max(maxWindow, end-start+1);
            }
            else
            {
                sum -= nums[start];
                start++;
            }
        }
        
        return maxWindow;
    }
}