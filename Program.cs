using System;
using System.Collections.Generic;

namespace c_sharp {
    class Program {

        static void Main (string[] args) {
            TestHeapSort();
        }

        static void TestHeapSort () {
            List<int> numbers = new List<int> ();
            numbers.Add (7);
            numbers.Add (1);
            numbers.Add (9);
            numbers.Add (2);
            numbers.Add (8);
            numbers.Add (3);
            numbers.Add (5);
            numbers.Add (4);
            Console.WriteLine (String.Join (", ", numbers));
            HeapSort sa = new HeapSort();
            sa.SortAl(ref numbers);
            Console.WriteLine (String.Join (", ", numbers));
            sa.SortAl(ref numbers);
            Console.WriteLine (String.Join (", ", numbers));
            numbers.Reverse ();
            Console.WriteLine (String.Join (", ", numbers));
            sa.SortAl(ref numbers);
            Console.WriteLine (String.Join (", ", numbers));

        }

        static void TestRecoverBST () {
            BSTNode root = new BSTNode ();
            root.data = 9;
            BSTNode left = new BSTNode ();
            left.data = 5;
            BSTNode right = new BSTNode ();
            right.data = 8;
            root.left = left;
            root.right = right;
            RecoverBST rb = new RecoverBST ();
            rb.MorrisTraverse1 (root);
            rb.Recover2 (root);
            rb.MorrisTraverse1 (root);
        }

        static void TestQuickSort () {
            List<int> numbers = new List<int> ();
            numbers.Add (7);
            numbers.Add (1);
            numbers.Add (9);
            numbers.Add (2);
            numbers.Add (8);
            numbers.Add (3);
            numbers.Add (5);
            numbers.Add (4);
            Console.WriteLine (String.Join (", ", numbers));
            SortAl sa = new SortAl ();
            sa.QuickSort (ref numbers);
            Console.WriteLine (String.Join (", ", numbers));
            sa.QuickSort (ref numbers);
            Console.WriteLine (String.Join (", ", numbers));
            numbers.Reverse ();
            Console.WriteLine (String.Join (", ", numbers));
            sa.QuickSort (ref numbers);
            Console.WriteLine (String.Join (", ", numbers));

        }

        static void TestRotatedAndSearch () {
            List<int> numbers = new List<int> ();
            numbers.Add (1);
            numbers.Add (2);
            numbers.Add (3);
            numbers.Add (4);
            numbers.Add (5);
            numbers.Add (6);
            numbers.Add (7);
            numbers.Add (8);
            Console.WriteLine (String.Join (", ", numbers));
            SearchRotated sr = new SearchRotated ();
            for (int i = 0; i < 10; i++) {
                sr.Rotate (ref numbers, 1);
                Console.WriteLine (String.Join (", ", numbers));
                int pos = sr.Search (numbers, 5);
                Console.WriteLine ("" + pos);
            }
        }

        static void TestUniqueChar () {
            string s = "hello world";
            UniqueCharsInString us = new UniqueCharsInString ();
            Console.WriteLine (s);
            string r = us.UniqueChars (s);
            Console.WriteLine (r);
        }

        static void TestFlattenBT () {
            BTNode root = new BTNode ();
            root.data = 2;
            BTNode left = new BTNode ();
            left.data = 1;
            BTNode right = new BTNode ();
            right.data = 3;
            root.left = left;
            root.right = right;
            FlattenBT fb = new FlattenBT ();
            fb.PrintBT (root);
            List<BTNode> flattened = fb.Flatten (root);
            fb.PrintFlatten (flattened);
        }

        static void TestCloneDoublyLinkedList () {
            ListNode node1 = new ListNode ();
            node1.data = 1;
            ListNode node2 = new ListNode ();
            node2.data = 2;
            ListNode node3 = new ListNode ();
            node3.data = 3;
            ListNode node4 = new ListNode ();
            node4.data = 4;

            node1.next = node2;
            node2.next = node3;
            node3.next = node4;

            node1.arbitary = node3;
            node2.arbitary = node4;
            // node3.arbitary = node1;
            node4.arbitary = node2;

            CloneList cl = new CloneList ();
            cl.PrintList (node1);
            ListNode newList = cl.DoClone (node1);
            cl.PrintList (newList);
        }

        static void TestCheckBST () {
            BSTNode root = new BSTNode ();
            root.data = 8;
            BSTNode left = new BSTNode ();
            left.data = 5;
            BSTNode right = new BSTNode ();
            right.data = 9;
            root.left = left;
            root.right = right;
            CheckBST cb = new CheckBST ();
            bool ret = cb.IsBST (root);
            Console.WriteLine ("" + ret);
        }

        static void TestMerge () {
            MergeList ml = new MergeList ();
            Node head1 = new Node ();
            Node cursor = head1;
            for (int i = 0; i < 5; i++) {
                cursor.next = new Node ();
                cursor.next.data = i * 2 + 1;
                cursor = cursor.next;
            }
            ml.PrintList (head1.next);
            Node head2 = new Node ();
            cursor = head2;
            for (int i = 0; i < 10; i++) {
                cursor.next = new Node ();
                cursor.next.data = i * 2;
                cursor = cursor.next;
            }
            ml.PrintList (head2.next);
            Node ret = ml.Merge (head1.next, head2.next);

            while (ret != null) {
                Console.WriteLine ("" + ret.data);
                ret = ret.next;
            }
        }
    }
}