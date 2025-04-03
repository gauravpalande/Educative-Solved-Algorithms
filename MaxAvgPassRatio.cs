using System;
using System.Collections.Generic;

public class Solution
{
   public static double CalculateGain(int passes, int total)
    {
        return ((double)(passes + 1) / (total + 1)) - ((double)passes / total);
    }

    public static double MaxAverageRatio(int[][] classes, int extraStudents)
    {
        var heap = new MaxHeap();

        foreach (var cls in classes)
        {
            int passes = cls[0], total = cls[1];
            double gain = CalculateGain(passes, total);
            heap.Push(gain, passes, total);
        }

        for (int i = 0; i < extraStudents; i++)
        {
            var (gain, passes, total) = heap.Pop();
            passes++;
            total++;
            gain = CalculateGain(passes, total);
            heap.Push(gain, passes, total);
        }

        double totalRatio = 0.0;
        while (heap.Count > 0)
        {
            var (_, passes, total) = heap.Pop();
            totalRatio += (double)passes / total;
        }

        return totalRatio / classes.Length;
    }
}