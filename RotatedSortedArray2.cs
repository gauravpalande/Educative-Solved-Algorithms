using System;

public class Solution {
    public static bool Search(int[] arr, int target) 
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] == target)
                return true;

            // Ambiguity due to duplicates
            if (arr[left] == arr[mid] && arr[mid] == arr[right])
            {
                left++;
                right--;
            }
            // Left half is sorted
            else if (arr[left] <= arr[mid])
            {
                if (arr[left] <= target && target < arr[mid])
                    right = mid - 1;
                else
                    left = mid + 1;
            }
            // Right half is sorted
            else
            {
                if (arr[mid] < target && target <= arr[right])
                    left = mid + 1;
                else
                    right = mid - 1;
            }
        }

        return false;
    }
}
