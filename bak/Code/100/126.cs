using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public partial class Solution
{
    public IList<IList<string>> FindLadders(string beginWord, string endWord, IList<string> wordList)
    {
        var steps = new Dictionary<string, int>();
        var result = new List<IList<string>>();
        var hs = new HashSet<string>(wordList);
        hs.Remove(beginWord);
        FindLadders(beginWord, endWord, hs, new List<string>() { beginWord }, result, steps);
        if (result.Count == 0)
            return result;
        return result.Where(p => p.Count == result.Min(q => q.Count)).ToList();
    }

    private IList<IList<string>> FindLadders(string beginWord, string endWord, HashSet<string> wordList, List<string> path, IList<IList<string>> result, Dictionary<string, int> minSteps)
    {
        //var result = new List<IList<string>>();
        if (beginWord == endWord)
        {
            result.Add(new List<string>(path));
        }
        else
        {
            var temp = new List<string>();
            for (int i = 0; i < beginWord.Length; i++)
            {
                var a = beginWord.ToCharArray();
                for (char c = 'a'; c <= 'z'; c++)
                {
                    a[i] = c;
                    var word = new string(a);
                    if (wordList.Contains(word))
                    {
                        var step = int.MaxValue;
                        var endStep = int.MaxValue;
                        if (minSteps.ContainsKey(word)) step = minSteps[word];
                        if (minSteps.ContainsKey(endWord)) endStep = minSteps[endWord];
                        if (path.Count + 1 <= step && path.Count + 1 <= endStep)
                        {
                            minSteps[word] = path.Count + 1;
                            temp.Add(word);                            
                        }
                    }
                    a[i] = beginWord[i];
                }
            }
            foreach (var word in temp)
            {
                path.Add(word);
                wordList.Remove(word);
                FindLadders(word, endWord, wordList, path, result, minSteps);
                path.RemoveAt(path.Count - 1);
                wordList.Add(word);
            }
        }
        return result;
    }

}