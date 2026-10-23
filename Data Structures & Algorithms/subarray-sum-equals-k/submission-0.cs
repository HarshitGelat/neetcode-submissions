public class Solution {
    public int SubarraySum(int[] nums, int k) {
        var prefixSum = new Dictionary<int, int>();
        prefixSum[0] = 1;
        int val = 0;
        int currentSum = 0;
        int res = 0;
        foreach(int num in nums) {
            currentSum += num;
            int diff = currentSum - k;

            prefixSum.TryGetValue(diff, out val);
            res += val;

            prefixSum.TryGetValue(currentSum, out val);
            prefixSum[currentSum] = 1 + val;
        }

        return res;
    }
}