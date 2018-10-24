using System;

namespace c_sharp {
    class Program {
        static void Main (string[] args) {
            // Console.WriteLine ("Hello World!");
            // twoSum ts = new twoSum ();
            // int[] a = { 1, 2, 3, 4, 5 };
            // int[] r = ts.s (a, 9);
            // Console.WriteLine ("" + r[0] + ", " + r[1]);
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