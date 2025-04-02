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
    public static LinkedListNode RemoveElements(LinkedListNode head, int k) 
    {
        LinkedListNode dummy = new LinkedListNode(0);
        dummy.next = head;

        LinkedListNode prev = dummy, curr = head;

        while (curr != null)
        {
            if (curr.data == k)
            {
                prev.next = curr.next;
                curr = curr.next;
            }
            else
            {
                prev = curr;
                curr = curr.next;
            }
        }

        return dummy.next;
    }
}