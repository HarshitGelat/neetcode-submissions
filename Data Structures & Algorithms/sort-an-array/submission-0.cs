public class Solution {
    public int[] SortArray(int[] nums) {
        if (nums.Length < 2) {
            return nums;
        }

        int i=0;
        int j=1;

        while(i < j) {
            if (nums[j] < nums [i]) {
                int temp = nums[j];
                nums[j] = nums[i];
                nums[i] = temp;
            }

            j++;

            if (j == (nums.Length)) {
                i++;
                j = i+1;
            }

            if (i == (nums.Length-1)) {
                j = i;
            }
        }
        return nums;
    }
}