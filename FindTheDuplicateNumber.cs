using System;

public class Solution{
    public static int FindDuplicate (int [] nums) 
    {
        int fast = nums[0];
        int slow = nums[0];

        while (true)
        {
            slow = nums[slow];
            fast = nums[nums[fast]];

            if (slow == fast)
            {
                break;
            }

        }

        slow = nums[0];

        while (slow != fast)
        {
            slow = nums[slow];
            fast = nums[fast];
        }
        
        return fast;
    }
}