using System;
using System.Collections.Generic;

// Definiton of a binary tree node class
// public class EduTreeNode
// {
//     public int data;
//     public EduTreeNode left;
//     public EduTreeNode right;
//     public EduTreeNode parent;

//     public EduTreeNode(int value)
//     {
//         this.data = value;
//         this.left = null;
//         this.right = null;
//         this.parent = null;
//     }
// }

public class Solution{
    public EduTreeNode LowestCommonAncestor(EduTreeNode p, EduTreeNode q){
      EduTreeNode i = p;
      EduTreeNode j = q;
      while(i != j)
      {
          i = i.parent;
          j = j.parent;
          
          if(i == null)
          {
              i = q;
          }
          if(j == null)
          {
              j = p;
          }
      }
      return i;
    }
}