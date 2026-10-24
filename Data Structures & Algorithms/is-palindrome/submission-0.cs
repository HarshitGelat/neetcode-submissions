public class Solution {
    public bool IsPalindrome(string s) {
        int j = s.Length-1;
        int i = 0;

        while (i<j) {
            // Skip ALL non-alphanumeric characters from the left
            if (!char.IsLetterOrDigit(s[i])) {
                i++;
                continue;
            }

            // Skip ALL non-alphanumeric characters from the right
            if (!char.IsLetterOrDigit(s[j])) {
                j--;
                continue;
            }

            if (char.ToLower(s[i]) != char.ToLower(s[j])) {
                return false;
            }

            i++;
            j--;
        }

        return true;
    }
}
