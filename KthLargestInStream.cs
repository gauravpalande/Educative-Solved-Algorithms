using System;

public class KthLargest
{
    public PriorityQueue<int, int> topKHeap;
    public int k;
    public int[] nums;
	// constructor to initialize topKHeap and add values in it
	public KthLargest(int k, int[] nums) {
	    k = k;
	    nums = nums;
		topKHeap = new PriorityQueue<int, int>();
		int i = 0;
		while(i < nums.Length)
		{
		    // fill heap
		    topKHeap.Enqueue(nums[i], nums[i]);
		    if (topKHeap.Count > k) {
                topKHeap.Dequeue(); // keep only k largest
            }
		    i++;
		}
	}

	// adds element in the topKHeap
	public int Add(int val) {
		    topKHeap.Enqueue(val, val);
        if (topKHeap.Count > k) {
            topKHeap.Dequeue();
        }
        return topKHeap.Peek(); // kth largest is root
	}
}