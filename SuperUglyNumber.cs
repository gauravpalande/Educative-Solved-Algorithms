using System;
using System.Collections.Generic;

public class Solution {
    public static int NthSuperUglyNumber(int n, int[] primes) {
        var minHeap = new PriorityQueue<long, long>();
        var seen = new HashSet<long>();

        minHeap.Enqueue(1, 1);
        seen.Add(1);

        long ugly = 1;

        for (int count = 0; count < n; count++) {
            ugly = minHeap.Dequeue();

            foreach (var prime in primes) {
                long next = ugly * prime;
                if (!seen.Contains(next)) {
                    seen.Add(next);
                    minHeap.Enqueue(next, next);
                }
            }
        }

        return (int)ugly;
    }
}
