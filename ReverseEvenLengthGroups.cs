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
    public static LinkedListNode ReverseEvenLengthGroups(LinkedListNode head)
    {
        LinkedListNode prev = head; 
        LinkedListNode node, reverse, currNext, curr, prevNext = null;
        int groupLen = 2; 
        int numNodes = 0;
        while (prev.next != null)
        {
            node = prev;
            numNodes = 0;
            for (int i = 0; i < groupLen; i++)
            {
                if (node.next == null)
                    break;
                numNodes += 1;
                node = node.next;
            }

            if (numNodes % 2 != 0) 
            {
                prev = node;
            }
            else
            {
                reverse = node.next;
                curr = prev.next;
                for (int j = 0; j < numNodes; j++)
                {
                    currNext = curr.next;
                    curr.next = reverse;
                    reverse = curr;
                    curr = currNext;
                }
                prevNext = prev.next;
                prev.next = node;
                prev = prevNext;
            }
            groupLen += 1;
        }
        return head;
    }
}