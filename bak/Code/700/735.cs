using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    public int[] AsteroidCollision(int[] asteroids)
    {
        var list = asteroids.ToList();
        while (true)
        {
            int? left = null;
            var c = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (left == null && list[i] < 0)
                    continue;
                else if (list[i] > 0)
                    left = i;
                else if (left != null && list[i] < 0)
                {
                    c++;
                    var v = list[left.Value];
                    if (list[left.Value] < -list[i])
                        v = list[i];
                    else if (list[left.Value] == -list[i])
                        v = 0;
                    list.RemoveAt(i);
                    list.RemoveAt(left.Value);
                    if (v != 0)
                        list.Insert(left.Value, v);
                    else
                        i--;
                    i--;
                    left = null;
                }

            }
            if (c == 0)
                break;
        }
        return list.ToArray();
    }
}
//[5,4,2,6,3,1,0,7]