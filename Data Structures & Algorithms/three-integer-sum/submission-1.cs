public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        int j;
        int k;
        int? previous = null;
        nums = nums.OrderBy(x => x).ToArray();

        var res = new List<List<int>>();

        for(int i=0; i<nums.Length-1; i++) {
            if (previous == nums[i]) {
                continue;
            }

            previous=nums[i];
            j=i+1;
            k=nums.Length-1;

            while(j<k) {
                if (nums[i] + nums[j] + nums[k] == 0) {
                    res.Add(new List<int> { nums[i], nums[j], nums[k] });
                    k--;
                    j++;

                    while (j < k && nums[j] == nums[j - 1]) {
                        j++;
                    }
                    while (j < k && nums[k] == nums[k + 1]) {
                        k--;
                    }
                } else if (nums[i] + nums[j] + nums[k] > 0) {
                    k--;
                } else {
                    j++;
                }
            }
        }

        return res;
    }
}
