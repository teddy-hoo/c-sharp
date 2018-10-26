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
      int pivot = nums[begin];
      int cursorBegin = begin;
      int cursorEnd = end;
      while (cursorBegin < cursorEnd) {
        while (nums[cursorEnd] >= pivot) {
          cursorEnd--;
        }
        nums[cursorBegin] = nums[cursorEnd];
        cursorBegin++;
        while (nums[cursorBegin] <= pivot) {
          cursorBegin++;
        }
        nums[cursorEnd] = nums[cursorBegin];
        cursorEnd--;
      }
      nums[cursorBegin] = pivot;
      _qs (ref nums, begin, cursorBegin - 1);
      _qs (ref nums, cursorBegin + 1, end);
    }
  }
}