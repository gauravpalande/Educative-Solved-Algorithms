using System;

public class Solution{
  
    public static int LargestInteger (int num) {
        List<int> digits = new List<int>();
        foreach (char c in num.ToString())
        {
            digits.Add(c - '0'); 
        }

        MaxHeap<int> oddHeap = new MaxHeap<int>((x, y) => x.CompareTo(y));
        MaxHeap<int> evenHeap = new MaxHeap<int>((x, y) => x.CompareTo(y));

        foreach (int d in digits)
        {
            if (d % 2 == 0)
                evenHeap.Enqueue(d); 
            else
                oddHeap.Enqueue(d);  
        }

        List<int> result = new List<int>();
        foreach (int d in digits)
        {
            if (d % 2 == 0)
            {
                int largestEven = evenHeap.Dequeue();
                result.Add(largestEven);
            }
            else
            {
                int largestOdd = oddHeap.Dequeue();
                result.Add(largestOdd);
            }
        }

        int outputNumber = 0;
        foreach (int d in result)
        {
            outputNumber = outputNumber * 10 + d;
        }

        return outputNumber;
    }
}