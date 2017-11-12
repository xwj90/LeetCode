using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    Dictionary<string, IList<IList<string>>> FindLadders_dict = new Dictionary<string, IList<IList<string>>>();

    public IList<IList<string>> FindLadders(string beginWord, string endWord, IList<string> wordList)
    {
        if (string.IsNullOrWhiteSpace(beginWord) || string.IsNullOrWhiteSpace(endWord))
            return new List<IList<string>>();
        HashSet<string> hs = new HashSet<string>();
        foreach (var item in wordList)
        {
            hs.Add(item);
        }
        return FindLadders(beginWord, endWord, hs);
    }
    public IList<IList<string>> FindLadders(string beginWord, string endWord, HashSet<string> hs)
    {
        if (FindLadders_dict.ContainsKey(beginWord))
            return FindLadders_dict[beginWord];
        var minLen = int.MaxValue;
        IList<IList<string>> result = new List<IList<string>>();
        for (int i = 0; i < beginWord.Length; i++)
            for (int c = 'a'; c < 'z'; c++)
            {
                if (c != beginWord[i])
                {
                    var a = beginWord.ToArray();
                    a[i] = (char)c;
                    var word = new string(a);
                    if (hs.Contains(word))
                    {
                        foreach (var r in FindLadders(word, endWord, hs))
                        {
                            if (r.Count < minLen)
                            {
                                result.Clear();
                                minLen = r.Count;
                            }
                            if (r.Count <= minLen)
                            {
                                r.Insert(0, beginWord);
                                result.Add(r);
                            }
                        }
                    }

                }
            }
        return result;
    }
    //    public IList<IList<string>> FindLadders(string beginWord, string endWord, IList<string> wordList)
    //{
    //    HashSet<string> begin = new HashSet<string>() { beginWord };
    //    HashSet<string> end = new HashSet<string>() { endWord };
    //    HashSet<String> visited = new HashSet<String>();
    //    int len = 0;
    //    while(begin.Count>0 && end.Count>0)
    //    {
    //        if(begin.Count>end.Count)
    //        {
    //            var t = end;
    //            end = begin;
    //            begin = t;
    //        }
    //        var temp = new HashSet<string>();
    //        foreach (var item in begin)
    //        {
    //            for (int i = 0; i < item.Length; i++)
    //                for (int c = 'a'; c < 'z'; c++)
    //                {
    //                    char old = item[i];
    //                    var a = item.ToArray();
    //                    a[i] = old;
    //                    var s = new string(a);
    //                    if (end.Contains(s))
    //                        return len + 1;


    //                }
    //        }
    //    }
    //}
}