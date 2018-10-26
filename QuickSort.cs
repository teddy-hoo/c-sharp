using System.Collections.Generic;

namespace c_sharp {
  class SortAl {
    public void QuickSort (ref List<int> nums) {
      _qs (ref nums, 0, nums.Count - 1);
    }

    private void _qs (ref List<int> nums, int begin, int end) {
      if (begin >= end) {
        return;
      }
      int pivotPost = _partition (ref nums, begin, end);
      _qs (ref nums, begin, pivotPost - 1);
      _qs (ref nums, pivotPost + 1, end);
    }

    private int _partition (ref List<int> nums, int begin, int end) {
      int pivot = nums[begin];
      int cursorBegin = begin;
      int cursorEnd = end;
      while (cursorBegin < cursorEnd) {
        while (cursorEnd > cursorBegin && nums[cursorEnd] >= pivot) {
          cursorEnd--;
        }
        if (cursorBegin != cursorEnd) {
          nums[cursorBegin] = nums[cursorEnd];
          cursorBegin++;
        }
        while (cursorEnd > cursorBegin && nums[cursorBegin] <= pivot) {
          cursorBegin++;
        }
        if (cursorBegin != cursorEnd) {
          nums[cursorEnd] = nums[cursorBegin];
          cursorEnd--;
        }
      }
      nums[cursorBegin] = pivot;
      return cursorBegin;
    }
  }
}