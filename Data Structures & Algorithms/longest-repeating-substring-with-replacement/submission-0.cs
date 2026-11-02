public class Solution {
    public int CharacterReplacement(string s, int k) {
        int l=0;
        var count = new Dictionary<char, int>();
        int maxL = 0;
        
        for(int r=0; r<s.Length; r++) {
            count[s[r]] = 1 + count.GetValueOrDefault(s[r], 0);

            while((r-l+1 - count.Values.Max()) > k) {
                count[s[l]] -=1;
                l++;
            }

            maxL = Math.Max(maxL, r - l + 1);
        }

        return maxL;
    }
}
