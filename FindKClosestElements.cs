using System;
using System.Collections.Generic;

public class Solution{
   public static IList<int> FindClosestElements(int[] nums, int k, int target) 
   {
        IList<int> closestElements = new List<int>();

        if (nums.Length == k)
        {
            closestElements = nums.ToList();
            return closestElements;
        }

        if (target <= nums[0])
        {
            for (int i = 0; i < k; i++)
            {
                closestElements.Add(nums[i]);
            }
            return closestElements;
        }

        if (target >= nums[nums.Length - 1])
        {
            for (int i = nums.Length - k; i < nums.Length; i++)
            {
                closestElements.Add(nums[i]);
            }
            return closestElements;
        }

        int firstClosest = BinarySearch.BinarySearchFunction(nums, target);
        int windowLeft = firstClosest - 1;
        int windowRight = windowLeft + 1;

        while ((windowRight - windowLeft - 1) < k)
        {
            if (windowLeft == -1)
            {
                windowRight++;
                continue;
            }

            if (windowRight == nums.Length || Math.Abs(nums[windowLeft] - target) <= Math.Abs(nums[windowRight] - target))
            {
                windowLeft--;
            }
            else
            {
                windowRight++;
            }
        }

        for (int i = windowLeft + 1; i < windowRight; i++)
        {
            closestElements.Add(nums[i]);
        }

        return closestElements;
    }
}