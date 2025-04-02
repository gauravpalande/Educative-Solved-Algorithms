/* Definition for a Linked List node
public class LinkedListNode
{
    public int data;
    public LinkedListNode next;
  
    public LinkedListNode(int data)
    {
        this.data = data;
        this.next = null;
    }
}*/

using System;

public class Solution {
    public static LinkedListNode[] SplitListToParts(LinkedListNode head, int k) 
    {
        LinkedListNode[] ans = new LinkedListNode[k];

        int size = 0;
        LinkedListNode current = head;
        while (current != null)
        {
            size++;
            current = current.next;
        }

        int split = size / k;

        int remaining = size % k;

        current = head;
        LinkedListNode prev = null;

        for (int i = 0; i < k; i++)
        {
            ans[i] = current;

            int currentSize = split + (remaining > 0 ? 1 : 0);
            if (remaining > 0) remaining--;

            for (int j = 0; j < currentSize; j++)
            {
                prev = current;
                if (current != null)
                {
                    current = current.next;
                }
            }

            if (prev != null)
            {
                prev.next = null;
            }
        }

        return ans;
    }
}