using System;

public class Solution
{
    public static int[][] InsertInterval(int[][] existingIntervals, int[] newInterval)
    {
        int newStart = newInterval[0];
        int newEnd = newInterval[1];

        int i = 0;
        int n = existingIntervals.Length;

        List<int[]> outputList = new List<int[]>();

        while (i < n && existingIntervals[i][0] < newStart)
        {
            outputList.Add(existingIntervals[i]);
            i += 1;
        }

        if (outputList.Count == 0 || outputList[outputList.Count - 1][1] < newStart)
        {
            outputList.Add(newInterval);
        }
        else
        {
            outputList[outputList.Count - 1][1] = Math.Max(outputList[outputList.Count - 1][1], newEnd);
        }

        while (i < n)
        {
            int[] existingInterval = existingIntervals[i];
            int start = existingInterval[0];
            int end = existingInterval[1];
            if (outputList[outputList.Count - 1][1] < start)
            {
                outputList.Add(existingInterval);
            }
            else
            {
                outputList[outputList.Count - 1][1] = Math.Max(outputList[outputList.Count - 1][1], end);
            }
            i += 1;
        }
        int[][] outputArray = outputList.ToArray();

        return outputArray;
    }
}