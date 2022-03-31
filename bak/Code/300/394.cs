using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public partial class Solution
{
    public string DecodeString(string s)
    {
        List<int> counts = new List<int>();
        List<string> re = new List<string>();
        var count = 0;
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < s.Length; i++)
        {
            var d = s[i] - '0';
            var ds = s[i] - 'a';
            if (d >= 0 && d <= 9)
                count = count * 10 + d;
            else if (ds >= 0 && ds <= 25)
            {
                if (re.Count > 0)
                    re[re.Count - 1] += s[i];
                else
                    sb.Append(s[i]);
            }
            else if (s[i] == '[')
            {
                counts.Add(count);
                re.Add("");
                count = 0;
            }
            else if (s[i] == ']' )
            {
                StringBuilder sb1 = new StringBuilder();
                for (int j = 0; j < counts[counts.Count - 1]; j++)
                {
                    sb1.Append(re[re.Count - 1]);
                }
                counts.RemoveAt(counts.Count - 1);
                re.RemoveAt(re.Count - 1);
                if(counts.Count>0)
                {
                    re[re.Count - 1] += sb1.ToString();
                }
                else
                {
                    sb.Append(sb1.ToString());
                }
            }          
           
        }
        return sb.ToString();
    }
}