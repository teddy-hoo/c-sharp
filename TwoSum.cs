using System;
using System.Collections.Generic;

namespace c_sharp {

    public class twoSum {

        public int[] s (int[] nums, int target) {
            Dictionary<int, int> hash = new Dictionary<int, int> ();
            for (int i = 0; i < nums.Length; i++) {
                hash.Add (nums[i], i);
            }
            for (int i = 0; i < nums.Length; i++) {
                int left = target - nums[i];
                if (hash.ContainsKey (left) && hash[left] > i) {
                    return new int[] { i, hash[left] };
                }
            }
            return new int[] {-1, -1 };
        }
    }
}