using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public static class AssertHelper
    {


        public static bool AssertCheck<T>(this IEnumerable<T> array, IEnumerable<T> t) where T : IEquatable<T>
        {
            var a = array.OrderBy(p => p).ToList();
            var b = t.OrderBy(p => p).ToList();

            if (a == null || t == null || a.Count != b.Count)
                return false;
            for (int i = 0; i < a.Count; i++)
            {
                if (!a[i].Equals(b[i]))
                    return false;
            }
            return true;
        }

        public static bool AssertCheckInOrder<T>(this IEnumerable<T> array, IEnumerable<T> t) where T : IEquatable<T>
        {
            var a = array.ToList();
            var b = t.ToList();

            if (a == null || t == null || a.Count != b.Count)
                return false;
            for (int i = 0; i < a.Count; i++)
            {
                if (!a[i].Equals(b[i]))
                    return false;
            }
            return true;
        }
    }
}