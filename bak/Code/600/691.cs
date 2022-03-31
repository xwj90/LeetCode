using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public partial class Solution
{
     
    public int MinStickers(string[] stickers, string target)
    {

        int[,] vs = new int[stickers.Length, 26];
        Dictionary<string, int> dict = new Dictionary<string, int>();
        HashSet<string> keys = new HashSet<string>();
        for (int i = 0; i < stickers.Length; i++)
        {
            var total = 0;
            foreach (var item in stickers[i])
            {
                vs[i, item - 'a']++;
                total++;
                //vs[i, 26] = vs[i, 26] | (1 << item - 'a');
            }
            
        }
         
        dict[""] = 0;
        var targetAarray = new int[26];
        foreach (var c in target)
            targetAarray[c - 'a']++;
        return MinStickers_Go(vs, dict, target);
    }

    int MinStickers_Go(int[,] vs, Dictionary<string, int> dict, string target)
    {
        if (dict.ContainsKey(target))
            return dict[target];
        int val = int.MaxValue;
        int[] total = new int[26];
        foreach (var c in target)
            total[c - 'a']++;
        
        for (int i = 0; i < vs.GetLength(0); i++)
        {
            if (vs[i, target[0] - 'a'] == 0) continue;
            StringBuilder sb = new StringBuilder();
            for (int j = 0; j < 26; j++)
                if (total[j] > 0)
                    for (int k = 0; k < Math.Max(0, total[j] - vs[i, j]); k++)
                    {
                        sb.Append((char)('a' + j));
                    }

            int temp = MinStickers_Go(vs, dict, sb.ToString());
            if (temp != -1)
                val = Math.Min(val, 1 + temp);
        }

        dict[target] = val == int.MaxValue ? -1 : val;
        return dict[target];
    }
}