using System;
using System.Collections.Generic;

namespace c_sharp {
  class TextJustification {
    public List<string> Justify (string[] words, int maxWidth) {
      List<string> ret = new List<string> ();
      List<string> window = new List<string> ();

      foreach (string s in words) {
        if (_exceedMaxWidth (window, s, maxWidth)) {
          string x = _composeLine (window, maxWidth);
          ret.Add (x);
          window.Clear ();
        }
        window.Add (s);
      }

      if (window.Count > 0) {
        string x = _composeLine (window, maxWidth, true);
        ret.Add (x);
      }

      return ret;
    }

    private bool _exceedMaxWidth (List<string> window, string next, int maxWidth) {
      int len = 0;
      foreach (string s in window) {
        len += s.Length + 1;
      }
      len += next.Length;
      return len > maxWidth;
    }

    private string _composeLine (List<string> window, int maxWidth, bool isLast = false) {
      int wordsLen = 0;
      foreach (string s in window) {
        wordsLen += s.Length;
      }
      string ret = "";

      if (window.Count == 1 || isLast) {
        ret = string.Join (" ", window);
        int len = ret.Length;
        while (len < maxWidth) {
          ret += " ";
          len++;
        }
        return ret;
      }

      for (int i = window.Count - 1; i >= 0; i--) {
        int left = maxWidth - wordsLen;
        wordsLen -= window[i].Length;
        int spaceCount = i == 0 ? 0 : left / i;
        maxWidth -= spaceCount + window[i].Length;
        ret = window[i] + ret;
        while (spaceCount > 0) {
          ret = " " + ret;
          spaceCount--;
        }
      }

      return ret;
    }

  }
}