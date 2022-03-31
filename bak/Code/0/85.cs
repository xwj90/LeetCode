using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    public int MaximalRectangle(char[,] matrix)
    {
        List<int> ls = new List<int>();
        for (int i = 0; i <= matrix.GetLength(0); i++)
        {
            ls.Add(0);
        }
        var totalArea = 0;
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                if (matrix[j, i] == '1')
                    ls[j]++;
                else
                    ls[j] = 0;
            }
            totalArea = Math.Max(totalArea, MaximalRectangle_LargestRectangleArea(ls));
        }
        return totalArea;
    }
    public int MaximalRectangle_LargestRectangleArea(List<int> ht)
    {
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