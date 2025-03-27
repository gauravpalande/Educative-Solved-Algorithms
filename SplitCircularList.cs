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
    public static LinkedListNode[] SplitCircularLinkedList(LinkedListNode head)
    {
        var slow = head;
        var fast = head.next;
        
        while(fast != head && fast.next != head)
        {
            slow = slow.next;
            fast = fast.next.next;
        }
        
        var ptr1 = head;
        var ptr2 = slow.next;
        
        slow.next = ptr1;
        
        fast = ptr2;
        var end = fast;
        while(fast != head)
        {
            end = fast;
            fast = fast.next;
        }
        
        end.next = ptr2;
        return new LinkedListNode[] {ptr1, ptr2};
    }
}