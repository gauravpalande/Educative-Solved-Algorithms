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

using System.Collections.Generic;

public class Solution
{
    public static LinkedListNode ReorderList(LinkedListNode head)
    {
        if (head == null)
            return head;

        LinkedListNode slow = head;
        LinkedListNode fast = head;

        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        LinkedListNode prev = null;
        LinkedListNode curr = slow;
        LinkedListNode next = null;

        while (curr != null)
        {
            next = curr.next;
            curr.next = prev;
            prev = curr;
            curr = next;
        }

        LinkedListNode first = head;
        LinkedListNode second = prev;
        LinkedListNode temp = head;

        while (second.next != null)
        {
            temp = temp.next;
            first.next = second;
            second = second.next;
            first.next.next = temp;
            first = first.next.next;
        }

        return head;
    }
}