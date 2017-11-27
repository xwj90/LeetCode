using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public partial class Solution
{
    List<IList<String>> results = new List<IList<string>>();
    List<String> list = new List<string>();
    Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();
    /// <summary>
    /// 
    /// </summary>
    /// <param name="beginWord"></param>
    /// <param name="endWord"></param>
    /// <param name="wordList"></param>
    /// <returns></returns>
    public IList<IList<string>> FindLadders(string beginWord, string endWord, IList<string> wordList)
    {
        if (wordList.Count == 0)
            return results;
        HashSet<string> dict = new HashSet<string>();
        foreach (var item in wordList)
            dict.Add(item);

        int curr = 1, next = 0;
        bool found = false;
        Queue<string> queue = new Queue<string>();
        HashSet<string> unvisited = new HashSet<string>(dict);
        HashSet<string> visited = new HashSet<string>();
        queue.Enqueue(beginWord);
        unvisited.Add(endWord);
        unvisited.Remove(beginWord);
        while(queue.Count>0)
        {
            var word = queue.Dequeue();
            curr--;
            for (int i = 0; i < word.Length; i++)
            {
                StringBuilder builder = new StringBuilder();
                for (char ch = 'a'; ch <='z' ; ch++)
                {
                    builder = new StringBuilder(word);
                    builder[i] = ch;
                    var new_word = builder.ToString();
                    if(unvisited.Contains(new_word))
                    {
                        if(visited.Add(new_word))
                        {
                            next++;
                            queue.Enqueue(new_word);
                        }
                        if (!map.ContainsKey(new_word))
                            map[new_word] = new List<string>() { word };
                        else
                            map[new_word].Add(word);
                        
                        if (new_word == endWord && !found)
                            found = true;
                    }
                }
            }

            if(curr==0)
            {
                if (found) break;
                curr = next;
                next = 0;
                unvisited.RemoveWhere(p => visited.Contains(p));
                visited.Clear();
            }
        }
        backTrace(endWord, beginWord);
        return results;
    }

    private void backTrace(string endWord, string beginWord)
    {
        if(endWord==beginWord)
        {
            list.Insert(0, beginWord);
            results.Add(new List<string>(list));
            list.RemoveAt(0);
            return;
        }
        list.Insert(0, endWord);
        if(map.ContainsKey(endWord) &&map[endWord]!=null)
            foreach (var s in map[endWord])
                backTrace(s,beginWord);

        list.RemoveAt(0);
    }
    /*
Dictionary<string, IList<IList<string>>> FindLadders_end_dict = new Dictionary<string, IList<IList<string>>>();
HashSet<string> start = new HashSet<string>();
public IList<IList<string>> FindLadders(string beginWord, string endWord, IList<string> wordList)
{
   if (string.IsNullOrWhiteSpace(beginWord) || string.IsNullOrWhiteSpace(endWord))
       return new List<IList<string>>();
   HashSet<string> hs = new HashSet<string>();
   HashSet<string> tested = new HashSet<string>() { };
   foreach (var item in wordList)
       hs.Add(item);

   hs.Remove(beginWord);
   return FindLadders(beginWord, endWord, hs, tested, int.MaxValue);
}
public IList<IList<string>> FindLadders(string beginWord, string endWord, HashSet<string> hs, HashSet<string> tested, int maxTarget)
{
   IList<IList<string>> result = new List<IList<string>>();

   if (FindLadders_end_dict.ContainsKey(beginWord))
       return FindLadders_end_dict[beginWord];
   if (beginWord == endWord)
       return new List<IList<string>>() { new List<string> { endWord } };

   List<string> candidates = new List<string>();
   for (int i = 0; i < beginWord.Length; i++)
       for (int c = 'a'; c <= 'z'; c++)
       {
           if (c != beginWord[i])
           {
               var a = beginWord.ToArray();
               a[i] = (char)c;
               var word = new string(a);
               if (hs.Contains(word))
               {
                   candidates.Add(word);
               }

           }
       }
   var minLen = int.MaxValue;
   foreach (var item in candidates)
       hs.Remove(item);
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
   foreach (var item in candidates)
       hs.Add(item);
   if (result.Count > 0)
       FindLadders_end_dict[beginWord] = result;
   return result;
}
*/
}