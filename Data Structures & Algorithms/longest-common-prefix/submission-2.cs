public class Solution {
    public string LongestCommonPrefix(string[] strs) {

        if (strs.Length == 0) return "";

        for (int i=0; i<strs[0].Length; i++) {
            var c = strs[0][i];
            foreach(string s in strs) {
                if (i >= s.Length || c != s[i]) {
                    return strs[0].Substring(0, i);
                }    
            }
        }

        return strs[0];
    }
}