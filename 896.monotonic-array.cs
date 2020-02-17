public class Solution
{
    public bool IsMonotonic(int[] A)
    {
        var increasing = true;
        var decresing = true;
        for (var i = 0; i < A.Length; i++)
        {
            if (i > 0 && A[i] < A[i - 1]) increasing = false;
            if (i > 0 && A[i] > A[i - 1]) decresing = false;
        }
        return increasing | decresing;

    }
}
// @lc code=end

