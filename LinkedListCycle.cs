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
    public static bool DetectCycle(LinkedListNode head) {
        var slow = head;
        var fast = head.next;
        
        while(slow != fast && fast.next != null && fast.next.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }
        
        return (slow == fast);
    }
}