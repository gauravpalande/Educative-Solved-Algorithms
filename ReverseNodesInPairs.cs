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

public class Solution{
    public static LinkedListNode SwapPairs(LinkedListNode head) {
        // Dummy node acts as the prevNode for the head node
        // of the list and hence stores pointer to the head node.
        LinkedListNode dummy = new LinkedListNode(-1);
        dummy.next = head;
        LinkedListNode prevNode = dummy;
        while ((head != null) && (head.next != null)) {
            // Nodes to be swapped
            LinkedListNode firstNode = head;
            LinkedListNode secondNode = head.next;
            // Swapping
            prevNode.next = secondNode;
            firstNode.next = secondNode.next;
            secondNode.next = firstNode;
            // Reinitializing the head and prevNode for next swap
            prevNode = firstNode;
            head = firstNode.next;  // jump
        }

        // Return the new head node.
        return dummy.next;
    }
}
