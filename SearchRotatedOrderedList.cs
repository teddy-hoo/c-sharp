using System.Collections.Generic;

namespace c_sharp {
  class SearchRotated {

    public int Search (List<int> numbers, int target) {
      int begin = 0;
      int end = numbers.Count - 1;
      while (begin <= end) {
        int mid = begin + (end - begin) / 2;
        if (numbers[mid] == target) {
          return mid;
        }
        if (numbers[mid] <= numbers[end]) {
          if (numbers[mid] < target && numbers[end] >= target) {
            begin = mid + 1;
          } else {
            end = mid - 1;
          }
        } else {
          if (numbers[mid] > target && numbers[begin] <= target) {
            end = mid - 1;
          } else {
            begin = mid + 1;
          }
        }
      }
      return -1;
    }

    public void Rotate (ref List<int> numbers, int offset) {
      offset = offset % numbers.Count;
      _swap (ref numbers, 0, numbers.Count - 1);
      _swap (ref numbers, 0, offset - 1);
      _swap (ref numbers, offset, numbers.Count - 1);
    }

    private void _swap (ref List<int> numbers, int begin, int end) {
      while (begin < end) {
        int tmp = numbers[begin];
        numbers[begin] = numbers[end];
        numbers[end] = tmp;
        begin++;
        end--;
      }
    }

  }
}