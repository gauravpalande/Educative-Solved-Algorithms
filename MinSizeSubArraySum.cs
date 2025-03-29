using System;

class Solution
{
    public static int MinSubArrayLen(int target, int[] nums)
    {
        int windowLength = int.MaxValue;
        int start = 0;
        int end = 0;
        int sum = 0;
        int n = nums.Length;
        
        while(end < n)
        {
            sum += nums[end];
            if(sum>= target)
                windowLength = Math.Min(windowLength, end-start + 1);
            
            while(sum >= target)
            {
                windowLength = Math.Min(windowLength, end-start  + 1);
                sum -= nums[start];
                start++;
            }
            end++;
        }
        
        if(start == 0 && end == n && sum < target)
        {
            return 0;
        }
        
        return windowLength;
    }
}