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
    public static LinkedListNode SwapNodes(LinkedListNode head, int k)
    {
        var curr = head;
        int count = 1;
        
        while (count < k)
        {
            curr = curr.next;
            count++;
        }
        
        var front = curr;
        var end = head;
        
        while(curr.next != null)
        {
            curr = curr.next;
            end = end.next;
        }
        
        int temp = front.data;
        front.data = end.data;
        end.data = temp;
        
        return head;
    }
}