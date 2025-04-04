using System;
using System.Collections.Generic;
using System.Linq;

class Pair
{
    public int Sum;
    public int I;
    public int J;

    public Pair(int sum, int i, int j)
    {
        Sum = sum;
        I = i;
        J = j;
    }
}


class Solution
{
    public static IList<IList<int>> KSmallestPairs(int[] list1, int[] list2, int k)
    {
        IList<IList<int>> pairs = new List<IList<int>>();
        int listLength = list1.Length;
        PriorityQueue<Pair> minHeap = new PriorityQueue<Pair>((a, b) => a.Sum - b.Sum);

        for (int i = 0; i < Math.Min(k, listLength); i++)
        {
            minHeap.Add(new Pair(list1[i] + list2[0], i, 0));
        }

        int counter = 1;

        while (minHeap.Count > 0 && counter <= k)
        {
            Pair pair = minHeap.Poll();
            int i = pair.I;
            int j = pair.J;
            pairs.Add(new List<int> { list1[i], list2[j] });
            int nextElement = j + 1;

            if (list2.Length > nextElement)
            {
                minHeap.Add(new Pair(list1[i] + list2[nextElement], i, nextElement));
            }
            counter++;
        }
        return pairs;
    }
}