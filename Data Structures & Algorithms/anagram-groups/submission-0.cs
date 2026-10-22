public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        
        var map = new Dictionary<string, List<string>>();

        foreach (var s in strs) {
            var chars = s.ToCharArray();
            Array.Sort(chars);

            var key = new string(chars);

            if (!map.TryGetValue(key, out var group)) {
                group = new List<string>();
                map[key] = group;
            }
            group.Add(s);
        }
        return map.Values.ToList();
    }
}
