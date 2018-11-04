using System.Collections.Generic;

namespace c_sharp {

  public class Parentheses {
    public bool Valid (string s) {
      Stack<char> stack = new Stack<char> ();
      foreach (char c in s) {
        if (c == '(' || c == '[' || c == '{') {
          stack.Push (c);
        } else if (c == ')' || c == ']' || c == '}') {
          if (stack.Count <= 0) {
            return false;
          }
          char x = stack.Pop ();
          if ((c == ']' && x != '[') ||
            (c == ')' && x != '(') ||
            (c == '}' && x != '{')
          ) {
            return false;
          }
        }
      }
      return stack.Count <= 0;
    }
  }

}