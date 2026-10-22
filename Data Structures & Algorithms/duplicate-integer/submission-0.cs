public class Solution {
    public bool hasDuplicate(int[] nums) {
        var seen = new HashSet<int>(nums.Length);
        foreach (int n in nums) {
            if (!seen.Add(n))
                return true;
        }

        return false;
    }
}