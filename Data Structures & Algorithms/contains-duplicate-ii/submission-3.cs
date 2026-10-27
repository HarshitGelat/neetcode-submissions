public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        var hashSet = new HashSet<int>();
        for(int j=0; j<nums.Length; j++) {
            if (!hashSet.Add(nums[j])) {
                return true;
            }
            
            if (hashSet.Count > k) {
                hashSet.Remove(nums[j - k]);
            }
        }

        return false;
    }
}