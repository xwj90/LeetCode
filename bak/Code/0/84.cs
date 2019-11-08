using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    public int LargestRectangleArea(int[] heights)
    {
        var ht = new List<int>();
        ht.AddRange(heights);
        ht.Add(0);
        int h, w, maxArea = 0;
        Stack<int> st = new Stack<int>();
        for (int i = 0; i < ht.Count; i++)
        {
            if (st.Count == 0 || ht[st.First()] < ht[i])
                st.Push(i);
            else
            {
                while (st.Count != 0 && ht[i] <= ht[st.First()])
                {
                    h = ht[st.First()];
                    st.Pop();
                    w = st.Count == 0 ? i : i - (st.First() + 1);
                    maxArea = Math.Max(maxArea, h * w);
                }
                st.Push(i);
            }
        }
        return maxArea;
    }
}