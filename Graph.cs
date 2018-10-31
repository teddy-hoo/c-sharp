using System.Collections.Generic;

namespace c_sharp {

  public class Graph {

    public bool IsBipartite (int[][] graph) {
      HashSet<int> setA = new HashSet<int> ();
      HashSet<int> setB = new HashSet<int> ();

      Queue<int[]> q = new Queue<int[]> ();

      for (int i = 0; i < graph.Length; i++) {
        if (setA.Contains (i) || setB.Contains (i)) {
          continue;
        }
        setA.Add (i);
        q.Enqueue (new int[] { i, 0 });
        while (q.Count > 0) {
          int[] cur = q.Dequeue ();
          int[] row = graph[cur[0]];
          foreach (int j in row) {
            if (cur[1] == 0) {
              if (setA.Contains (j)) {
                return false;
              } else if (!setB.Contains (j)) {
                setB.Add (j);
                q.Enqueue (new int[] { j, 1 });
              }
            } else {
              if (setB.Contains (j)) {
                return false;
              } else if (!setA.Contains (j)) {
                setA.Add (j);
                q.Enqueue (new int[] { j, 0 });
              }
            }
          }
        }
      }
      return true;
    }

  }

}