/*
 * @lc app=leetcode id=535 lang=csharp
 *
 * [535] Encode and Decode TinyURL
 */
public class Codec
{

    // Encodes a URL to a shortened URL
    Dictionary<int, string> dictionary = new Dictionary<int, string>();
    int i = 0;
    public string encode(string longUrl)
    {

        dictionary[i] = longUrl;

        return $"http://tinyurl.com/{i++}";

    }

    // Decodes a shortened URL to its original URL.
    public string decode(string shortUrl)
    {
        var value = Convert.ToInt32(shortUrl.Substring("http://tinyurl.com/".Length ));
        return dictionary[value].ToString();
    }
}

// Your Codec object will be instantiated and called as such:
// Codec codec = new Codec();
// codec.decode(codec.encode(url));

