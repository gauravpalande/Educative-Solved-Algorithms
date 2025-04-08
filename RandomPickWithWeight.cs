using System;
using System.Collections.Generic;

class Solution
{
    private List<int> runningSums;
    private int totalSum;
    private Random random;

    public Solution(int[] weights)
    {
        runningSums = new List<int>();
        int runningSum = 0;

        foreach (int w in weights)
        {
            runningSum += w;
            runningSums.Add(runningSum);
        }

        totalSum = runningSum;
        random = new Random();
    }

    // Method to pick an index based on the weights
    public int PickIndex()
    {
        int target = random.Next(totalSum) + 1;
        int low = 0;
        int high = runningSums.Count;

        while (low < high)
        {
            int mid = low + (high - low) / 2;
            if (target > runningSums[mid])
            {
                low = mid + 1;
            }
            else
            {
                high = mid;
            }
        }

        return low;
    }

    // Driver code
    public static void Main(string[] args)
    {
        int counter = 900;

        int[][] weights = {
            new int[] {1, 2, 3, 4, 5},
            new int[] {1, 12, 23, 34, 45, 56, 67, 78, 89, 90},
            new int[] {10, 20, 30, 40, 50},
            new int[] {1, 10, 23, 32, 41, 56, 62, 75, 87, 90},
            new int[] {12, 20, 35, 42, 55},
            new int[] {10, 10, 10, 10, 10},
            new int[] {10, 10, 20, 20, 20, 30},
            new int[] {1, 2, 3},
            new int[] {10, 20, 30, 40},
            new int[] {5, 10, 15, 20, 25, 30}
        };

        Dictionary<int, int> map = new Dictionary<int, int>();
        for (int i = 0; i < weights.Length; i++)
        {
            Console.WriteLine($"{(i + 1)}.\tList of weights: {string.Join(", ", weights[i])}, pick_index() called {counter} times\n");
            for (int l = 0; l < weights[i].Length; l++)
            {
                map[l] = 0;
            }
            Solution sol = new Solution(weights[i]);
            for (int j = 0; j < counter; j++)
            {
                int index = sol.PickIndex();
                map[index] = map.ContainsKey(index) ? map[index] + 1 : 1;
            }
            Console.WriteLine(new string('-', 100));
            Console.WriteLine($"\t{"Indexes",-10}{"|"}{"Weights",-10}{"|"}{"\tOccurrences",-14}{"|"}{"\tActual Frequency",-20}{"|"}{"\tExpected Frequency",-15}");
            Console.WriteLine(new string('-', 100));
            foreach (KeyValuePair<int, int> entry in map)
            {
                int key = entry.Key;
                int value = entry.Value;
                Console.WriteLine($"\t{key,-10}|{weights[i][key],-10}|{value,-15}|{((double)value / counter) * 100,20:F2}%|{((double)weights[i][key] / Sum(weights[i])) * 100,15:F2}%");
            }
            map.Clear();
            Console.WriteLine(new string('-', 100));
        }
    }

    private static int Sum(int[] arr)
    {
        int total = 0;
        foreach (int num in arr)
        {
            total += num;
        }
        return total;
    }
}
