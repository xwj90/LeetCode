using System;

public partial class Solution
{
    public int MaxArea(int[] height)
    {
        int left = 0;
        int right = height.Length - 1;
        int maxArea = 0;
        int k = 0;
        while (left < right)
        {
            maxArea = Math.Max(maxArea, Math.Min(height[left], height[right]) * (right - left));
            if (height[left] > height[right])
            {
                k = right;
                while (k > left && height[k] <= height[right])
                    k--;
                right = k;
            }
            else
            {
                k = left;
                while (k < right && height[k] <= height[left])
                    k++;
                left = k;
            }
        }
        return maxArea;
    }
}