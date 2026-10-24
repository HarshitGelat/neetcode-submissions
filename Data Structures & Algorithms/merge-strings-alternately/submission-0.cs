public class Solution {
    public string MergeAlternately(string word1, string word2) {
        int minLength = Math.Min(word1.Length, word2.Length);
        StringBuilder res = new StringBuilder();

        for (int i = 0; i < minLength; i++) {
            res.Append(word1[i]);
            res.Append(word2[i]);
        }

        if (word1.Length > minLength) {
            res.Append(word1.Substring(minLength));
        } else if (word2.Length > minLength) {
            res.Append(word2.Substring(minLength));
        }

        return res.ToString();
    }
}