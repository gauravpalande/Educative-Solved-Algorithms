using System;

public class Solution{
    public static int MaxScore (int[] nums, int target) 
    {
        var maxHeap = new PriorityQueue<int, int>();
        
        foreach(int num in nums)
        {
            maxHeap.Enqueue(num, num*-1);
        }
        
        int score = 0;
        while(target > 0)
        {
            int max = maxHeap.Dequeue();
            score += max;
            max = (int)Math.Ceiling((double)max/3);
            maxHeap.Enqueue(max, max*-1);
            target--;
        }
        
        return score;
    }
}