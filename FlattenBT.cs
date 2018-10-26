using System;
using System.Collections.Generic;

namespace c_sharp {

  class BTNode {
    public int data;
    public BTNode left;
    public BTNode right;
  }

  class FlattenBT {

    public List<BTNode> Flatten (BTNode root) {
      List<BTNode> ret = new List<BTNode> ();
      Queue<BTNode> q = new Queue<BTNode> ();
      BTNode curLayer = null;
      BTNode layerCursor = null;
      BTNode curNode = null;

      if (root == null) {
        return ret;
      }

      q.Enqueue (root);
      q.Enqueue (null);

      while (q.Count > 0) {
        curNode = q.Dequeue ();
        if (curNode != null) {
          if (curNode.left != null) {
            q.Enqueue (curNode.left);
          }
          if (curNode.right != null) {
            q.Enqueue (curNode.right);
          }
          if (curLayer == null) {
            curLayer = curNode;
            layerCursor = curNode;
          } else {
            layerCursor.left = curNode;
            layerCursor.right = null;
            layerCursor = curNode;
          }
        } else {
          layerCursor.left = null;
          layerCursor.right = null;
          ret.Add (curLayer);
          curLayer = null;
          layerCursor = null;
          if (q.Count > 0) {
            q.Enqueue (null);
          }
        }
      }
      return ret;
    }

    public void PrintBT (BTNode root) {

      Queue<BTNode> q = new Queue<BTNode> ();
      BTNode curNode = null;

      q.Enqueue (root);
      q.Enqueue (null);
      string line = "";

      while (q.Count > 0) {
        curNode = q.Dequeue ();
        if (curNode != null) {
          if (curNode.left != null) {
            q.Enqueue (curNode.left);
          }
          if (curNode.right != null) {
            q.Enqueue (curNode.right);
          }
          line += curNode.data + ", ";
        } else {
          Console.WriteLine (line);
          line = "";
          if (q.Count > 0) {
            q.Enqueue (null);
          }
        }
      }
    }

    public void PrintFlatten (List<BTNode> l) {
      for (int i = 0; i < l.Count; i++) {
        string line = "";
        BTNode cur = l[i];
        while (cur != null) {
          line += cur.data + ", ";
          cur = cur.left;
        }
        Console.WriteLine (line);
      }
    }

  }

}