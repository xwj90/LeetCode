using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public partial class Solution
{
    int[] a = null;
    public Solution(int[] nums)
    {
        // i feel no.384 is a bug
        this.a = nums;
    }

    /** Resets the array to its original configuration and return it. */
    public int[] Reset()
    {
        return a;
    }

    /** Returns a random shuffling of the array. */
    public int[] Shuffle()
    {
        Random r = new Random();
        var c = a.ToList();
        List<int> f = new List<int>();
        while (c.Count > 0)
        {
            var id = r.Next(c.Count);
            f.Add(c[id]);
            c.RemoveAt(id);
        }
        return f.ToArray();
    }
}

