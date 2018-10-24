using System;
using System.Collections.Generic;

namespace c_sharp {

  class BSTNode {
    public int data;
    public BSTNode left;
    public BSTNode right;
  }

  class CheckBST {

    public bool IsBST (BSTNode root) {
      if (root == null) {
        return true;
      }
      Queue<BSTNode> nodeQueue = new Queue<BSTNode> ();
      Queue<Int64[]> boundaryQueue = new Queue<Int64[]> ();

      nodeQueue.Enqueue (root);
      boundaryQueue.Enqueue (new Int64[] { Int64.MinValue, Int64.MaxValue });

      while (nodeQueue.Count > 0) {
        BSTNode curNode = nodeQueue.Dequeue ();
        Int64[] curBoundary = boundaryQueue.Dequeue ();
        if (curNode.data < curBoundary[0] || curNode.data > curBoundary[1]) {
          return false;
        }
        if (curNode.left != null) {
          Int64[] newBoundary = new Int64[] { curBoundary[0], curNode.data };
          nodeQueue.Enqueue (curNode.left);
          boundaryQueue.Enqueue (newBoundary);
        }
        if (curNode.right != null) {
          Int64[] newBoundary = new Int64[] { curNode.data, curBoundary[1] };
          nodeQueue.Enqueue (curNode.right);
          boundaryQueue.Enqueue (newBoundary);
        }
      }

      return true;
    }

  }

}