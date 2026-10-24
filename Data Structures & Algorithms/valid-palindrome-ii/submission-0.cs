public class Solution {
    public bool ValidPalindrome(string s) {
        int j = s.Length-1;
        int i = 0;
        int i1 = 0;
        int j1 = 0;
        int deleteCount = 0;

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
                i1 = i+1;
                j1 = j-1;
                break;
            }

            i++;
            j--;
        }

        while (i1<j) {
            // Skip ALL non-alphanumeric characters from the left
            if (!char.IsLetterOrDigit(s[i1])) {
                i1++;
                continue;
            }

            // Skip ALL non-alphanumeric characters from the right
            if (!char.IsLetterOrDigit(s[j])) {
                j--;
                continue;
            }

            if (char.ToLower(s[i1]) != char.ToLower(s[j])) {
                deleteCount++;
                break;
            }

            i1++;
            j--;
        }

        while (i<j1) {
            // Skip ALL non-alphanumeric characters from the left
            if (!char.IsLetterOrDigit(s[i])) {
                i++;
                continue;
            }

            // Skip ALL non-alphanumeric characters from the right
            if (!char.IsLetterOrDigit(s[j1])) {
                j1--;
                continue;
            }

            if (char.ToLower(s[i]) != char.ToLower(s[j1])) {
                deleteCount++;
                break;
            }

            i++;
            j1--;
        }
        return deleteCount == 2 ? false : true;
    }
}