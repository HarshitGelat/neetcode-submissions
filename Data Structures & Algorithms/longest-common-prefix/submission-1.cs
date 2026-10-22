public class Solution {
    public string LongestCommonPrefix(string[] strs) {

        if (strs.Length == 0 || String.Equals(strs[0], "")) {
            return "";
        }

        var result = "";

        for (int i=0; i<strs[0].Length; i++) {
            var c = strs[0][i];
            foreach(string s in strs) {
                if (i >= s.Length || c != s[i]) {
                    return result;
                }    
            }
            result += c;
        }

        return result;
    }
}