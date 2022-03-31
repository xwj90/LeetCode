using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class ArrayHelper
{
    static Random r = new Random();
    public static string ToCompareString(this int[] a)
    {
        return string.Join(",", a);
    }

    public static string ToDisplayString(this char[,] a)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < a.GetLength(0); i++)
        {
            string s = "";
            for (int j = 0; j < a.GetLength(1); j++)
            {
                s += "," + a[i, j];
            }
            sb.AppendLine(s.Trim(','));
        }
        return sb.ToString();
    }
    public static bool Any(this char[,] c, Func<char,bool> p)
    {
        for (int i = 0; i < c.GetLength(0); i++)
        {
            for (int j = 0; j < c.GetLength(1); j++)
            {
                if (p(c[i, j]))
                    return true;
            }
        }
        return false;
    }
    public static int[] RandomGenerate(int c = 100, int max = 10000)
    {
        int[] result = new int[c];
        for (int i = 0; i < result.Length; i++)
            result[i] = r.Next(0, max);
        return result;
    }

    public static int[,] GenerateMatrix(string s= "1,2,3,4,5,6,7,8,9")
    {
        var a = s.Split(',');
        var l = Convert.ToInt32(Math.Sqrt(a.Length));
        var m = new int[l, l];
        for (int i = 0; i <a.Length; i++)
        {
            var x = i / l;
            var y = i % l;
            m[x, y] = Convert.ToInt32(a[i]);
        }
        return m;
    }

    public static string ToSquareString(this IList<string> s)
    {
        StringBuilder sb = new StringBuilder();
        var split = Convert.ToInt32(Math.Sqrt(s.Count));
        for (int i = 0; i < s.Count; i++)
        {
            if (i % split == 0 && i / split > 0)
                sb.AppendLine();
            sb.Append(s[i]);            
        }
        return sb.ToString();
    }

    //public static string ToFlatString(this int[,] s)
    //{

    //}
}

