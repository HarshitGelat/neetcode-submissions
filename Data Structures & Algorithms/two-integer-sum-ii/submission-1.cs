public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int i = 0;
        int j = numbers.Length - 1;

        while(i<j) {
            if (numbers[i] + numbers[j] == target) {        
                break;
            } else if (numbers[i] + numbers[j] > target) {        
                j--;
            } else {
                i++;
            }
        }

        return [i+1, j+1];
    }
}
