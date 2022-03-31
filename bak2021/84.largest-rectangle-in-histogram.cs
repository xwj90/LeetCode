public class Solution
{

    public int LargestRectangleArea(int[] heights)
    {
        if (heights == null || heights.Length == 0) return 0;
        var lessFromLeft = new int[heights.Length];
        var lessFromRight = new int[heights.Length];
        lessFromRight[heights.Length - 1] = heights.Length;
        lessFromLeft[0] = -1;

        for (var i = 1; i < heights.Length; i++)
        {
            int p = i - 1;
            while (p >= 0 && heights[p] >= heights[i])
                p = lessFromLeft[p];
            lessFromLeft[i] = p;
        }

        for (var i = heights.Length - 2; i >= 0; i--)
        {
            int p = i + 1;
            while (p < heights.Length && heights[p] >= heights[i])
                p = lessFromRight[p];
            lessFromRight[i] = p;
        }

        int maxArea = 0;
        for (var i = 0; i < heights.Length; i++)
        {
            var l = lessFromLeft[i];
            var r = lessFromRight[i];
            maxArea = Math.Max(maxArea, heights[i] * (r - l - 1));
        }
        return maxArea;

    }
}
// @lc code=end

