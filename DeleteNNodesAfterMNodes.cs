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
    public static LinkedListNode DeleteNodes(LinkedListNode head, int m, int n)
    {
        var prev = new LinkedListNode(0);
        var cur = head;
        
        prev.next = cur;
        
        while(cur != null)
        {
            int i = 0;
            while(cur != null && i < m)
            {
                prev = cur;
                cur = cur.next;
                i++;
            }
            
            int j = 0;
            while(cur != null && j < n)
            {
                cur = cur.next;
                j++;
            }
            
            prev.next = cur;
        }
        
        return head;
    }
}