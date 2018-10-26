using System;

namespace c_sharp {
  class RecoverBST {

    public BSTNode pre;
    public BSTNode first;
    public BSTNode second;

    public void Recover1 (BSTNode root) {
      InOrder (root);
      if (first != null && second != null) {
        int tmp = second.data;
        second.data = first.data;
        first.data = tmp;
      }
    }

    public void Recover2 (BSTNode root) {
      MorrisTraverse (root);
      if (first != null && second != null) {
        int tmp = second.data;
        second.data = first.data;
        first.data = tmp;
      }
    }

    public void InOrder (BSTNode root) {
      if (root == null) return;
      InOrder (root.left);
      if (pre == null) pre = root;
      if (pre.data > root.data) {
        if (first == null) first = pre;
        second = root;
      }
      pre = root;
      InOrder (root.right);
    }

    public void PrintBST (BSTNode root) {
      if (root == null) return;
      PrintBST (root.left);
      Console.WriteLine ("" + root.data + ", ");
      PrintBST (root.right);
    }

    public void MorrisTraverse (BSTNode root) {
      BSTNode prev;
      BSTNode cur = root;
      while (cur != null) {
        if (cur.left == null) {
          Check (cur);
          cur = cur.right;
        } else {
          prev = cur.left;
          while (prev.right != null && prev.right != cur) {
            prev = prev.right;
          }
          if (prev.right == null) {
            prev.right = cur;
            cur = cur.left;
          } else {
            prev.right = null;
            Check (cur);
            cur = cur.right;
          }
        }
      }
    }

    public void Check (BSTNode cur) {
      if (pre == null) pre = cur;
      if (pre.data > cur.data) {
        if (first == null) first = pre;
        second = cur;
      }
      pre = cur;
    }

    public void MorrisTraverse1 (BSTNode root) {
      BSTNode pre;
      BSTNode cur = root;
      while (cur != null) {
        if (cur.left == null) {
          Console.WriteLine ("" + cur.data);
          cur = cur.right;
        } else {
          pre = cur.left;
          while (pre.right != null && pre.right != cur) {
            pre = pre.right;
          }
          if (pre.right == null) {
            pre.right = cur;
            cur = cur.left;
          } else {
            pre.right = null;
            Console.WriteLine ("" + cur.data);
            cur = cur.right;
          }
        }
      }
    }

  }
}