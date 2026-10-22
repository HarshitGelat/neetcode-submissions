public class Solution {
    public int LongestConsecutive(int[] nums) {
        if (nums == null || nums.Length == 0) return 0;

        var numSet = new HashSet<int>(nums);
        int longestSequence = 0;

        foreach (int num in numSet) {
            // Only start counting if this number is the absolute start of a sequence
            if (!numSet.Contains(num - 1)) {
                int currentNum = num;
                int currentStreak = 1;

                // Count upward by checking the HashSet
                while (numSet.Contains(currentNum + 1)) {
                    currentNum++;
                    currentStreak++;
                }

                if (currentStreak > longestSequence) {
                    longestSequence = currentStreak;
                }
            }
        }

        return longestSequence;
    }
}