public class Solution {
    public void SortColors(int[] nums) {
        var colors = new int[3];

        for (int i = 0; i < nums.Length; i++) {
            colors[nums[i]]++;
        }

        var index = 0;
        for (int i = 0; i < colors.Length; i++) {
            for (int j = 0; j < colors[i]; j++) {
                nums[index] = i;
                index++;
            }
        }
    }
}