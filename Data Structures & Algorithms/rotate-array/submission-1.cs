public class Solution {
    public void Rotate(int[] nums, int k) {
        int temp;
        for(int i=0; i<k; i++) {
            temp = nums[nums.Length-1];
            for(int j=nums.Length-2; j>=0; j--) {
                nums[j+1] = nums[j];
            }
            nums[0] = temp;
        }
    }
}