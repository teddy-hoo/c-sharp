namespace c_sharp {
  public class MergeSrot {

    public void MSort (ref int[] numbers) {
      _mSort (ref numbers, 0, numbers.Length - 1);
    }

    public void _mSort (ref int[] numbers, int begin, int end) {
      if (begin >= end) {
        return;
      }
      int mid = begin + (end - begin) / 2;
      _mSort (ref numbers, begin, mid);
      _mSort (ref numbers, mid + 1, end);
      int[] tmp = _merge (numbers, begin, mid + 1, end);
      for (int i = begin, j = 0; i <= end; i++) {
        numbers[i] = tmp[j];
        j++;
      }
    }

    public int[] _merge (int[] numbers, int begin, int begin2, int end) {
      int[] tmp = new int[end - begin + 1];
      int cursor = 0;
      int end1 = begin2 - 1;
      while (begin <= end1 && begin2 <= end) {
        if (numbers[begin] <= numbers[begin2]) {
          tmp[cursor] = numbers[begin];
          begin++;
        } else {
          tmp[cursor] = numbers[begin2];
          begin2++;
        }
        cursor++;
      }

      while (begin <= end1) {
        tmp[cursor] = numbers[begin];
        begin++;
        cursor++;
      }

      while (begin2 <= end) {
        tmp[cursor] = numbers[begin2];
        begin2++;
        cursor++;
      }

      return tmp;
    }

  }
}