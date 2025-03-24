using System;
using System.Collections.Generic;

public class Solution
{
    public static IList<IList<int>> ThreeSum(int[] nums)
    {
        Array.Sort(nums);
        List<IList<int>> result = new List<IList<int>>();
        int n = nums.Length;

        for (int pivot = 0; pivot < n - 2; pivot++)
        {
            if (nums[pivot] > 0)
            {
                break;
            }
            if (pivot > 0 && nums[pivot] == nums[pivot - 1])
            {
                continue;
            }

            int low = pivot + 1, high = n - 1;
            while (low < high)
            {
                int total = nums[pivot] + nums[low] + nums[high];
                if (total < 0)
                {
                    low++;
                }
                else if (total > 0)
                {
                    high--;
                }
                else
                {
                    result.Add(new List<int> { nums[pivot], nums[low], nums[high] });
                    low++;
                    high--;
                    while (low < high && nums[low] == nums[low - 1])
                    {
                        low++;
                    }
                    while (low < high && nums[high] == nums[high + 1])
                    {
                        high--;
                    }
                }
            }
        }

        return result;
    }
}