public class Solution {
    public int MaxArea(int[] heights) {
        int min;
        int dist;
        int res = 0;

        int i=0;
        int j=heights.Length-1;
        while(i<j) {
            min = Math.Min(heights[i],heights[j]);
            dist = j-i;
            int newRes = min*dist;

            if (newRes > res) {
                res = newRes;
            }

            if (heights[i] <= heights[j]) {
                i++;

                while(i < j && heights[i] < min) {
                    i++;
                }
            } else if (heights[i] > heights[j]) {
                j--;

                while(j > i && heights[j] < min) {
                    j--;
                }
            }    
         }

         return res;
    }
}
