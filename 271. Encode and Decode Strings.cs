public class Codec
{

    // Encodes a list of strings to a single string.
    public string encode(IList<string> strs)
    {
        var prefix = strs.Count + "," + string.Join(",", strs.Select(p => p.Length)) + ",";
        return prefix + string.Join("", strs);
    }

    // Decodes a single string to a list of strings.
    public IList<string> decode(string s)
    {
        var res = new List<string>();
        var start = 0;
        var next = s.IndexOf(",");
        var count = Convert.ToInt32(s.Substring(start, next - start));
        var lengths = new List<int>();
        for (var i = 0; i < count; i++)
        {
            start = next + 1;
            next = s.IndexOf(",", start);
            var len = Convert.ToInt32(s.Substring(start, next - start));
            lengths.Add(len);
        }

        start = next + 1;
        for (var i = 0; i < count; i++)
        {
            var str = s.Substring(start, lengths[i]);
            res.Add(str);
            start += lengths[i];
        }
        return res;
    }
}

// Your Codec object will be instantiated and called as such:
// Codec codec = new Codec();
// codec.decode(codec.encode(strs));