public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int length = nums.Length;
        int[] output = new int[length];
        
       output[0] = 1;
       
       for(int i=1; i<length; i++) {
        output[i] = output[i-1] * nums[i-1];
       }

      int postfix = 1; 
       for(int i=length-1; i>=0; i--) {
        output[i] *= postfix;
        postfix *= nums[i];
       }

       return output;
    }
}