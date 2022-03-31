using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public partial class Solution
{
    public string Multiply(string num1, string num2)
    {
        Dictionary<int, int> d = new Dictionary<int, int>();
        for (int i = 0; i < num1.Length; i++)
        {
            for (int j = 0; j < num2.Length; j++)
            {
                Multiply_Add(d, num1.Length + num2.Length - i - j - 2, (num1[i] - '0') * (num2[j] - '0'));
            }
        }
        if (d.Count == 0)
            return "0";
        var max = d.Keys.Max();
        StringBuilder sb = new StringBuilder();
        for (int i = max; i >= 0; i--)
        {
            if (d.ContainsKey(i))
                sb.Append(d[i]);
            else
                sb.Append("0");
        }

        return sb.ToString();
    }
    void Multiply_Add(Dictionary<int, int> d, int id, int val)
    {
        if (val == 0)
            return;
        var t = d.ContainsKey(id) ? d[id] : 0;
        var v = val + t;
        var m = v % 10;
        d[id] = m;
        Multiply_Add(d, id + 1, v / 10);
    }
    //public List<string> Multiply_Go(string num1, string num2)
    //{
    //    if (num1.Length > num2.Length)
    //        return Multiply_Go(num2, num1);
    //    List<string> ls = new List<string>();
    //    if (num1.Length == 1 && num2.Length == 1)
    //    {
    //        ls.Add((Convert.ToInt32(num1) * Convert.ToInt32(num2)).ToString());
    //        return ls;
    //    }
    //    foreach (var item in Multiply_Go(num1, num2.Substring(0, num2.Length - 1)))
    //        ls.Add(item + "0");
    //    if (num2[num2.Length - 1] != '0')
    //        ls.AddRange(Multiply_Go(num2.Substring(num2.Length - 1), num1));
    //    return ls;
    //}
}
