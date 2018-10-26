using System;
using System.Collections.Generic;

namespace c_sharp {

  class UniqueCharsInString {
    public string UniqueChars (string str) {
      HashSet<char> s = new HashSet<char> ();
      for (int i = 0; i < str.Length; i++) {
        s.Add (str[i]);
      }
      List<char> l = new List<char> ();
      foreach (char c in s) {
        l.Add (c);
      }
      l.Sort ();
      string ret = "";
      for (int i = 0; i < l.Count; i++) {
        ret += l[i];
      }
      return ret;
    }
  }

}