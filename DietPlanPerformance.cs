using System;
using System.Collections.Generic;

public class Solution{
   public static double FindMaxAverage(int[] nums, int k)
   {
      int sum = 0;
      int start = 0;
      int n = nums.Length;
      int maxSum = int.MinValue;
      
      for(int i = 0; i < k; i++)
      {
          sum += nums[i];
      }
      
      maxSum = Math.Max(maxSum, sum);
      
      for(int end = k; end < n; end++)
      {
          sum-= nums[start];
          start++;
          sum += nums[end];
          maxSum = Math.Max(maxSum, sum);
      }
      
      return (double) maxSum/k;
    }
}