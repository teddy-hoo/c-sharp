using System;

namespace c_sharp {
  public class RegularExpressionMatching {
    public bool IsMatch (string s, string p) {
      if (s.Length == 0 || p.Length == 0) {
        return false;
      }
      int sLen = s.Length;
      int pLen = p.Length;
      bool[][] cache = new bool[sLen + 1][];
      for (int i = 0; i < sLen + 1; i++) {
        cache[i] = new bool[pLen + 1];
      }

      for (int i = 0; i < sLen + 1; i++) {
        for (int j = 0; j < pLen + 1; j++) {
          cache[i][j] = false;
        }
      }

      cache[0][0] = true;
      for (int i = 0; i <= sLen; ++i) {
        for (int j = 1; j <= pLen; ++j) {
          if (j > 1 && p[j - 1] == '*') {
            cache[i][j] = cache[i][j - 2] || (i > 0 && (s[i - 1] == p[j - 2] || p[j - 2] == '.') && cache[i - 1][j]);
          } else {
            cache[i][j] = i > 0 && cache[i - 1][j - 1] && (s[i - 1] == p[j - 1] || p[j - 1] == '.');
          }
        }
      }
      return cache[sLen][pLen];
    }
  }
}