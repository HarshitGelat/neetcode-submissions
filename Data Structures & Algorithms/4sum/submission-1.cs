public class Solution {
    public List<List<int>> FourSum(int[] nums, int target) {
        Array.Sort(nums);
        return KSum(nums, target, 0, 4);
    }

    private List<List<int>> KSum(int[] nums, long target, int start, int k) {
        var res = new List<List<int>>();
        
        // Fix: Cast to long to prevent overflow during pruning
        if (start == nums.Length || (long)nums[start] * k > target || target > (long)nums[nums.Length - 1] * k) {
            return res;
        }

        if (k == 2) {
            return TwoSum(nums, target, start);
        }

        for (int i = start; i <= nums.Length - k; i++) {
            if (i > start && nums[i] == nums[i - 1]) continue;

            var subResults = KSum(nums, target - nums[i], i + 1, k - 1);
            
            foreach (var list in subResults) {
                var currentList = new List<int> { nums[i] };
                currentList.AddRange(list);
                res.Add(currentList);
            }
        }

        return res;
    }

    private List<List<int>> TwoSum(int[] nums, long target, int start) {
        var res = new List<List<int>>();
        int left = start;
        int right = nums.Length - 1;

        while (left < right) {
            long sum = (long)nums[left] + nums[right];

            if (sum == target) {
                res.Add(new List<int> { nums[left], nums[right] });
                left++;
                right--;

                while (left < right && nums[left] == nums[left - 1]) left++;
                while (left < right && nums[right] == nums[right + 1]) right--;
            } 
            else if (sum < target) {
                left++;
            } 
            else {
                right--;
            }
        }
        return res;
    }
}