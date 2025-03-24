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
    public static LinkedListNode RemoveNthLastNode(LinkedListNode head, int n)
    {
        var left = head;
        var right = head;
        int i = 0;
        
        // Moving right n nodes
        while(i < n)
        {
            right = right.next;
            i++;
        }
        
        if(right == null)
        {
            return left.next;
        }
        
        // Moving right and left till right reaches the end
        while(right.next != null)
        {
            right = right.next;
            left = left.next;
        }
        
        // eliminate left node
        left.next = left.next.next;

        return head;
    }
}