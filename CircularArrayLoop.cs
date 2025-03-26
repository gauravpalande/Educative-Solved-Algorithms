using System;

public class Solution{
   public static bool CircularArrayLoop(int[] nums) 
   {
        int size = nums.Length;

        for (int i = 0; i < size; i++)
        {
            int slow = i, fast = i;
            bool forward = nums[i] > 0;

            while (true)
            {
                slow = NextStep(slow, nums[slow], size);

                if (IsNotCycle(nums, forward, slow))
                    break;

                fast = NextStep(fast, nums[fast], size);

                if (IsNotCycle(nums, forward, fast))
                    break;

                fast = NextStep(fast, nums[fast], size);

                if (IsNotCycle(nums, forward, fast))
                    break;

                if (slow == fast)
                    return true;
            }
        }

        return false;
    }

    // A function to calculate the next step
    public static int NextStep(int pointer, int value, int size)
    {
        int result = (pointer + value) % size;
        if (result < 0)
            result += size;
        return result;
    }

    // A function to detect a cycle doesn't exist
    public static bool IsNotCycle(int[] nums, bool prevDirection, int pointer)
    {
        bool currDirection = nums[pointer] >= 0;

        if (prevDirection != currDirection || nums[pointer] % nums.Length == 0)
        {
            return true;
        }

        return false;
    }
}