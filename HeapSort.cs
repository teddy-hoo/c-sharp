using System.Collections.Generic;

namespace c_sharp {
    
    class HeapSort {

        public void SortAl(ref List<int> numbers) {
            int len = numbers.Count - 1;
            int begin = (len - 1) / 2;
            while(begin >= 0) {
                _adjust(ref numbers, begin, len);
                begin --;
            }
            int end = len;
            while(end > 0) {
                _swap(ref numbers, 0, end);
                end--;
                _adjust(ref numbers, 0, end);
            }
        }

        private void _adjust(ref List<int> numbers, int rootPos, int end) {
            int len = end;
            while(rootPos < len) {
                int left = rootPos * 2 + 1;
                int right = rootPos * 2 + 2;
                int maxIndex = right;
                if (right <= len) {
                    if (numbers[right] < numbers[left] ) {
                        maxIndex = left;
                    }
                } else if (left <= len) {
                    maxIndex = left;
                } else {
                    return;
                }
                if (numbers[rootPos] >= numbers[maxIndex]) {
                    return;
                }
                _swap(ref numbers, rootPos, maxIndex);
                rootPos = maxIndex;
            }
        }

        private void _swap(ref List<int> numbers, int a, int b) {
            int tmp = numbers[a];
            numbers[a] = numbers[b];
            numbers[b] = tmp;
        }

    }

}