namespace c_sharp {
  public class ContainerWithMostWater {

    public int MostWater (int[] height) {
      int maxArea = 0;
      int i = 0;
      int j = height.Length - 1;
      while (i < j) {
        int h = height[i];
        if (height[j] < height[i]) {
          h = height[j];
        }
        int a = h * (j - i);
        maxArea = maxArea > a ? maxArea : a;
        if (height[j] < height[i]) {
          j--;
        } else {
          i++;
        }
      }
      return maxArea;
    }

  }
}