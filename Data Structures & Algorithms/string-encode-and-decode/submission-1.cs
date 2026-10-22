public class Solution {
    public string Encode(IList<string> strs) {
        StringBuilder sb = new StringBuilder();

        foreach(string s in strs) {
            sb.Append(s.Length).Append('#').Append(s);
        }

        return sb.ToString();
    }

    public List<string> Decode(string s) {
        List<string> result = new List<string>();
        int i=0;

        while(i<s.Length) {
            int delimiterIndex = s.IndexOf('#', i);

            int length = int.Parse(s.Substring(i, delimiterIndex - i));

            result.Add(s.Substring(delimiterIndex + 1, length));

            i = delimiterIndex + 1 + length;
        }
        return result;
   }
}
