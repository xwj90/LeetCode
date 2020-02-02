public class Solution
{
    Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
    public int LadderLength(string beginWord, string endWord, IList<string> wordList)
    {
        var L = beginWord.Length;
        foreach (var w in wordList)
            for (var i = 0; i < w.Length; i++)
            {
                var newWord = w.Substring(0, i) + "*" + w.Substring(i + 1);
                var list = new List<string>();
                if (dict.ContainsKey(newWord)) list = dict[newWord];
                list.Add(w);
                dict[newWord] = list;
            }

        Queue<(string, int)> queue = new Queue<(string, int)>();
        queue.Enqueue((beginWord, 1));

        var hs = new HashSet<string>();
        hs.Add(beginWord);
        while (queue.Any())
        {
            var item = queue.Dequeue();
            var word = item.Item1;
            var level = item.Item2;
            for (var i = 0; i < L; i++)
            {
                var newWord = word.Substring(0, i) + "*" + word.Substring(i + 1);
                if (dict.ContainsKey(newWord))
                {
                    foreach (var w in dict[newWord])
                    {
                        if (w == endWord) return level + 1;
                        if (!hs.Contains(w))
                        {
                            hs.Add(w);
                            queue.Enqueue((w, level + 1));
                        }
                    }
                }
            }
        }
        return 0;
    }
}
// @lc code=end

