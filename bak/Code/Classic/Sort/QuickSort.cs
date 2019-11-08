using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code.Classic.Sort
{
    public class QuickSort
    {
        public static int[] Sort(int[] a)
        {
            List<int> r = new List<int>() { a[0] };

            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] >= r[r.Count - 1])
                    r.Add(a[i]);
                else
                {
                    var left = 0;
                    var right = r.Count - 1;
                    var mid = 0;
                    while (left <= right)
                    {
                        mid = (left + right) / 2;
                        if (a[i] < r[mid])
                            right = mid - 1;
                        else
                            left = mid + 1;
                    }
                    r.Insert(left, a[i]);
                }
            }
            return r.ToArray();
        }
    }
}
