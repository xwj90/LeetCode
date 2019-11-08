using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public partial class Solution
{
    public string ReverseWords(string s)
    {
        var a = s.Split(' ');
        //StringBuilder sb = new StringBuilder();
        for (int i = 0; i < a.Length; i++)
        {
            a[i] = new string(a[i].Reverse().ToArray());
        }
        return string.Join(" ", a);
    }
}