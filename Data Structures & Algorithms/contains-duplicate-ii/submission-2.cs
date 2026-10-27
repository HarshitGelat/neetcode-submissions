public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        var hashSet = new HashSet<int>();
        int count = 0;
        for(int j=0; j<nums.Length; j++) {
            if (count > k) {
                hashSet.Remove(nums[j-k-1]);
                count--;
            }

            if (hashSet.Contains(nums[j])) {
                return true;
            } else {
                hashSet.Add(nums[j]);
            }
            count++;
        }

        return false;
    }
}