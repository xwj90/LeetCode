public class Solution
{
    public string ReverseStr(string s, int k)
    {
        var arr = s.ToCharArray();
        for (var j = 0; j < s.Length; j += 2 * k)
        {
            if (j + k <= s.Length)
            {
                Reverse(arr, j, j + k - 1);
                continue;
            }
            Reverse(arr, j, s.Length - 1);
        }
        return new string(arr);
    }
    
    public void Reverse(char[] arr, int left, int right)
    {
        while (right > left)
        {
            var temp = arr[left];
            arr[left] = arr[right];
            arr[right] = temp;

            right--;
            left++;
        }
    }
}
// @lc code=end

