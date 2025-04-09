using System;
using System.Collections.Generic;

public class Solution
{
    public static bool JumpGame(int[] nums)
    {
        int n = nums.Length;
        int target = n-1;
        int i = n-1;
        
        while(i >= 0)
        {
            if(target - i <= nums[i])
            {
                target = i;
            }
            i--;
        }
        
        return target == 0;
    }
}