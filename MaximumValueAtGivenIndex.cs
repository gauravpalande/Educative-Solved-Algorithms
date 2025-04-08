using System;

public class Solution {
    public static int CalculateSum(int index, int mid, int n)
    {
        int count = 0;

        if (mid > index)
        {
            count += (mid + (mid - index)) * (index + 1) / 2;
        }
        else
        {
            count += (mid + 1) * mid / 2 + (index - mid + 1);
        }

        if (mid >= n - index)
        {
            count += (mid + (mid - n + 1 + index)) * (n - index) / 2;
        }
        else
        {
            count += (mid + 1) * mid / 2 + (n - index - mid);
        }

        return count - mid;
    }

    // Method to calculate the max mid
    public static int MaxValue(int n, int index, int maxSum)
    {
        int left = 1, right = maxSum;

        while (left < right)
        {
            int mid = (left + right + 1) / 2;

            if (CalculateSum(index, mid, n) <= maxSum)
            {
                left = mid;
            }
            else
            {
                right = mid - 1;
            }
        }

        return left;
    }
}