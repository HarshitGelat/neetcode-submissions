public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) {
            return false;
        }

        var counts = new int[26];

        for (int i = 0; i < s.Length; i++) {
            counts[s[i] - 'a']++;
            counts[t[i] - 'a']--;
        }

        foreach (int c in counts) {
            if (c != 0) return false;
        }

        return true;
    }
}
