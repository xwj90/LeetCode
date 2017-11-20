using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    Dictionary<string, IList<IList<string>>> FindLadders_end_dict = new Dictionary<string, IList<IList<string>>>();

    public IList<IList<string>> FindLadders(string beginWord, string endWord, IList<string> wordList)
    {
        var words = wordList;
        words.Insert(0, beginWord);
        words.Add(endWord);
        int[,] dis = new int[words.Count , words.Count ];
        for (int i = 0; i < dis.GetLength(0); i++)
            for (int j = 0; j < dis.GetLength(1); j++)
                dis[i, j] = int.MaxValue;
        for (int i = 0; i < dis.GetLength(0); i++)
            dis[i, i] = 0;
        for (int i = 0; i < dis.GetLength(0); i++)
            for (int j = 0; j < dis.GetLength(1); j++)
            {
                if (i != j && OnlyOne(words[i], words[j]))
                    dis[i, j] = 1;
            }
        for (int k = 0; k < dis.GetLength(0); k++)
            for (int i = 0; i < dis.GetLength(0); i++)
                for (int j = 0; j < dis.GetLength(1); j++)
                {
                    if (dis[i, j] > dis[i, k] + dis[k, j])
                        dis[i, j] = dis[i, k] + dis[k, j];
                }
        return null;
    }

    private bool OnlyOne(string v1, string v2)
    {
        for (int i = 0; i < v1.Length; i++)
        {
            var a = v1.ToCharArray();
            for (int j = 0; j <= 25; j++)
            {
                a[i] = (char)(j+ 'a');
                var s = new string(a);
                if (v2 == s)
                    return true;
            }
        }
        return false;
    }
    /*
Dictionary<string, IList<IList<string>>> FindLadders_end_dict = new Dictionary<string, IList<IList<string>>>();

public IList<IList<string>> FindLadders(string beginWord, string endWord, IList<string> wordList)
{
   if (string.IsNullOrWhiteSpace(beginWord) || string.IsNullOrWhiteSpace(endWord))
       return new List<IList<string>>();
   HashSet<string> hs = new HashSet<string>();
   HashSet<string> tested = new HashSet<string>() { };
   foreach (var item in wordList)
   {
       hs.Add(item);
   }
   return FindLadders(beginWord, endWord, hs, tested, int.MaxValue);
}
public IList<IList<string>> FindLadders(string beginWord, string endWord, HashSet<string> hs, HashSet<string> tested, int maxTarget)
{
   IList<IList<string>> result = new List<IList<string>>();
   //if (tested.Contains(beginWord))
   //    return result;
   //else
   //    tested.Add(beginWord);
   if (FindLadders_end_dict.ContainsKey(beginWord))
       return FindLadders_end_dict[beginWord];
   if (beginWord == endWord)
       return new List<IList<string>>() { new List<string> { endWord } };
   var minLen = int.MaxValue;
   List<string> candidates = new List<string>();
   for (int i = 0; i < beginWord.Length; i++)
       for (int c = 'a'; c < 'z'; c++)
       {
           if (c != beginWord[i])
           {
               var a = beginWord.ToArray();
               a[i] = (char)c;
               var word = new string(a);
               if (hs.Contains(word) && !tested.Contains(word))
               {
                   candidates.Add(word);
               }

           }
       }

   tested.Add(beginWord);
   foreach (var word in candidates)
   {
       var rs = FindLadders(word, endWord, hs, tested, minLen);
       foreach (var r in rs)
       {
           if (r.Count < minLen)
           {
               result.Clear();
               minLen = r.Count;
           }
           if (r.Count <= minLen)
           {
               var list = new List<string>() { beginWord };
               list.AddRange(r);
               result.Add(list);
           }
       }
   }
   tested.Remove(beginWord);
   if (result.Count > 0)
       FindLadders_end_dict[beginWord] = result;
   return result;
}
*/
}