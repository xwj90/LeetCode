public class Solution
{
    public bool IsAlienSorted(string[] words, string order)
    {
        var index = new int[26];
        for (int i = 0; i < order.Length; ++i)
            index[order[i] - 'a'] = i;

        for (int i = 0; i < words.Length - 1; ++i)
        {
            var word1 = words[i];
            var word2 = words[i + 1];

            var status = false;
            for (int k = 0; k < Math.Min(word1.Length, word2.Length); ++k)
            {
                if (word1[k] != word2[k])
                {
                    // If they compare badly, it's not sorted.
                    if (index[word1[k] - 'a'] > index[word2[k] - 'a'])
                        return false;
                    status = true;
                    break;
                }
            }
            if(status) continue;
            if(word1.Length>word2.Length) return false; // compare char with empty
        }
        return true;
    }
}
// @lc code=end

