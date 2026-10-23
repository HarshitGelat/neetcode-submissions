public class Solution {
    public int FirstMissingPositive(int[] nums) {
        int numsLength = nums.Length;

        for(int i=0; i<numsLength; i++) {
            if (nums[i] < 0) {
                nums[i] = 0;
            }
        }

        for(int i=0; i<numsLength; i++) {
            int  index = Math.Abs(nums[i]) - 1;
            if (index >= 0 && index < numsLength) {
                nums[index] = -1 * Math.Abs(nums[index]);
            }
            if (nums[i] == 0) {
                nums[i] = numsLength + 1;
            }
        }

        for(int i=0; i<numsLength; i++) {
            if (nums[i] > 0) {
                return i + 1;
            }
        }

        return numsLength + 1;
    }
}