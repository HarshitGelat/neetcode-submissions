public class Solution {
    public List<int> MajorityElement(int[] nums) {
        int candidate1 = 0, candidate2 = 0;
        int count1 = 0, count2 = 0;

        // Pass 1: find up to two possible candidates
        foreach (int num in nums)
        {
            if (num == candidate1)
            {
                count1++;
            }
            else if (num == candidate2)
            {
                count2++;
            }
            else if (count1 == 0)
            {
                candidate1 = num;
                count1 = 1;
            }
            else if (count2 == 0)
            {
                candidate2 = num;
                count2 = 1;
            }
            else
            {
                count1--;
                count2--;
            }
        }

        // Pass 2: verify the real counts
        count1 = 0;
        count2 = 0;
        foreach (int num in nums)
        {
            if (num == candidate1) count1++;
            else if (num == candidate2) count2++;
        }

        var result = new List<int>();
        int threshold = nums.Length / 3;

        if (count1 > threshold) result.Add(candidate1);
        if (count2 > threshold) result.Add(candidate2);

        return result;
    }
}