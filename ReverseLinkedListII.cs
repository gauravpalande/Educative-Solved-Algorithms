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
using System.Collections.Generic;

public class Solution
{
    public static LinkedListNode ReverseBetween(LinkedListNode head, int left, int right)
    {
        if (head == null || left == right)
            return head;

        LinkedListNode dummy = new LinkedListNode(0);
        dummy.next = head;
        LinkedListNode prev = dummy;

        for (int i = 0; i < left - 1; i++)
            prev = prev.next;

        LinkedListNode curr = prev.next;

        for (int i = 0; i < right - left; i++) {
            LinkedListNode nextNode = curr.next;
            curr.next = nextNode.next;
            nextNode.next = prev.next;
            prev.next = nextNode;
        }

        return dummy.next;
    }
}