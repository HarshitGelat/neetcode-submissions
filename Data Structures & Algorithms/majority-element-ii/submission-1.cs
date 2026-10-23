public class Solution {
    public List<int> MajorityElement(int[] nums) {
        return FindMajority(nums, 3);   // k = 3 for this problem
    }

    private List<int> FindMajority(int[] nums, int k) {
        int limit = k - 1;                 // max candidates we can keep
        var count = new Dictionary<int, int>();

        // Pass 1: find possible candidates
        foreach (int num in nums) {
            count.TryGetValue(num, out int c);
            count[num] = c + 1;

            if (count.Count <= limit) continue;

            // limit + 1 distinct numbers: subtract 1 from each, drop zeros
            var newCount = new Dictionary<int, int>();
            foreach (var kv in count) {
                if (kv.Value > 1) {
                    newCount[kv.Key] = kv.Value - 1;
                }
            }
            count = newCount;
        }

        // Pass 2: verify real counts
        var verify = new Dictionary<int, int>();
        foreach (int num in nums) {
            if (count.ContainsKey(num)) {
                verify.TryGetValue(num, out int c);
                verify[num] = c + 1;
            }
        }

        int threshold = nums.Length / k;   // the "major" variable
        var res = new List<int>();
        foreach (var kv in verify) {
            if (kv.Value > threshold) {
                res.Add(kv.Key);
            }
        }
        return res;
    }
}