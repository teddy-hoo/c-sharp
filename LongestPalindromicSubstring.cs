using System;
using System.Collections.Generic;

namespace c_sharp {

  public class LongestPalindromicSubstring {
    public string LongestPalindrome (string s) {
      if (s.Length <= 0) {
        return "";
      }
      int len = s.Length;
      int[][] cache = new int[len][];
      for (int i = 0; i < len; i++) {
        cache[i] = new int[len];
      }
      for (int i = 0; i < len; i++) {
        for (int j = 0; j < len; j++) {
          cache[i][j] = i >= j ? 1 : 0;
        }
      }
      int maxLen = 1;
      int maxI = 0;
      for (int subLen = 2; subLen <= len; subLen++) {
        for (int i = 0; i + subLen - 1 < len; i++) {
          int j = i + subLen - 1;
          if (cache[i + 1][j - 1] == 0) {
            cache[i][j] = 0;
          } else if (s[i] == s[j]) {
            cache[i][j] = 1;
            if (subLen > maxLen) {
              maxLen = subLen;
              maxI = i;
            }
          } else {
            cache[i][j] = 0;
          }
        }
      }

      return s.Substring (maxI, maxLen);
    }
  }

}