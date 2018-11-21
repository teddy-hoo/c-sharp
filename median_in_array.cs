using System;
					
public class Program
{
	public static void Main()
	{
		int[] nums = new int[]{9,8,7,6,5,4,3,2,1};
		Console.WriteLine(findMedian(nums));
	}
	
	public static double findMedian(int[] nums) {
		int mid1 = (nums.Length + 1) / 2;
		int mid2 = (nums.Length + 2) / 2;
		
		int v1 = findKth(nums, mid1);
		int v2 = v1;
		if (mid1 != mid2) {
			v2 = findKth(nums, mid2);
		}
		
		return (v1 + v2) / 2.0;
	}
	
	public static int findKth(int[] nums, int target) {
		
		int start = 0;
		int end = nums.Length - 1;
		
		int mid = partition(nums, start, end);
		while(mid != target - 1) {
			if (mid < target - 1) {
				start = mid + 1;
			} else {
				end = mid - 1;
			}
			mid = partition(nums, start, end);
		}
		
		return nums[mid];	
	}
	
	public static int partition(int[] nums, int start, int end) {
		int pivot = nums[start];
		
		while (start < end) {
			while(nums[end] >= pivot && end > start) {
				end--;
			}
			if (start != end) {
				nums[start] = nums[end];
				start++;
			}
			
			while(nums[start] <= pivot && end > start) {
				start++;
			}
			if (start != end) {
				nums[end] = nums[start];
				end--;
			}
			
		}
		nums[start] = pivot;
		Console.WriteLine(String.Join(",", nums));
		return start;
	}
}
