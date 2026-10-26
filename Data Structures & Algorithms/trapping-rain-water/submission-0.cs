public class Solution {
    public int Trap(int[] height) {
        int count = 0;
        int i=0;
        int j=height.Length-1;
        int maxL = height[i];
        int maxR = height[j];
        while(i<=j) {
            if(maxL<=maxR) {
                if (maxL - height[i] > 0) {
                    count += maxL - height[i];
                }
                maxL = Math.Max(maxL, height[i]);
                i++;
            } else {
                if (maxR - height[j] > 0) {
                    count += maxR - height[j];
                }
                maxR = Math.Max(maxR, height[j]);
                j--;
            }
        }
        return count;
    }
}
