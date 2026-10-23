public class Solution {
    public int FirstMissingPositive(int[] nums) {
        for(int i=0; i<nums.Length; i++) {
            if (nums[i] < 0) {
                nums[i] = 0;
            }
        }

        for(int i=0; i<nums.Length; i++) {
            int  index = Math.Abs(nums[i]) - 1;
            if (index >= 0 && index < nums.Length) {
                nums[index] = -1 * Math.Abs(nums[index]);
            }
            if (nums[i] == 0) {
                nums[i] = nums.Length + 1;
            }
        }

        for(int i=0; i<nums.Length; i++) {
            if (nums[i] > 0) {
                return i + 1;
            }
        }

        return nums.Length + 1;
    }
}