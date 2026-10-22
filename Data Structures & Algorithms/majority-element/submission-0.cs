public class Solution {
    public int MajorityElement(int[] nums) {
        var data = new Dictionary<int, int>();
        var count = 0;
        var val = 0;;
        for(var i=0; i<nums.Length; i++) {
            if (!data.ContainsKey(nums[i])) {
                data[nums[i]] = 0;
            }
            
            data[nums[i]]++;
            if (data[nums[i]] > count) {
                count = data[nums[i]];
                val = nums[i];
            }
        }

        return val;
    }
}