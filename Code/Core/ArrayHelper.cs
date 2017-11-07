using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static  class ArrayHelper
{
    public static string ToCompareString(this int[] a)
    {
        return string.Join(",", a);
    }
}

