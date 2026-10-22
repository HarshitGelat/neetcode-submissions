public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var digits = new int[2001];
        var unique = new int[k];
        var kCount = 0;

        for(int i=0; i<nums.Length; i++) {
            digits[nums[i] + 1000]++;

            if (kCount < k) {
                if (digits[nums[i] + 1000] == 1) {
                    unique[kCount] = nums[i];
                    kCount++;
                }
            } else {
                var inUnique = false;
                var minIdx = 0;

                for (int j = 0; j < k; j++) {
                    if (unique[j] == nums[i]) {
                        inUnique = true;
                        break;
                    }
                    if (digits[unique[j] + 1000] < digits[unique[minIdx] + 1000]) {
                        minIdx = j;
                    }
                }

                if (!inUnique && digits[nums[i] + 1000] > digits[unique[minIdx] + 1000]) {
                    unique[minIdx] = nums[i];
                }
            }
        }

        return unique;
    }
}
