using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    public string SimplifyPath(string path)
    {
        var a = path.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
        Stack<string> r = new Stack<string>();
        for (int i = 0; i < a.Length; i++)
            if (a[i] == "..")
            {
                if (r.Count > 0)
                    r.Pop();
            }
            else if (a[i] == ".")
                continue;
            else
                r.Push(a[i]);
        return "/" + string.Join("/", r.Reverse());
    }

}
