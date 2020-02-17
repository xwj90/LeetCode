public class Solution
{
    public int ReversePairs(int[] nums)
    {
        if(nums.Length==0) return 0;
        int res = 0; 
        Seg tree = new Seg() { Min = nums.Min(), Max = nums.Max() };
        for (int j = 1; j < nums.Length; j++)
        {
            tree.Add(nums[j - 1]);
            res += tree.Search(nums[j] * 2L + 1L);
        }
        return res;
    }

    public class Seg
    {
        public long Min, Max;
        public int Count;
        public Seg Left, Right;

        public void Add(long n)
        {
            Count++;
            if (Min == Max) return;
            long mid = (Max - Min) / 2 + Min;
            if (n <= mid)
            {
                if (Left == null) Left = new Seg() { Min = Min, Max = mid };
                Left.Add(n);
            }
            else
            {
                if (Right == null) Right = new Seg() { Min = mid + 1, Max = Max };
                Right.Add(n);
            }
        }

        public int Search(long n)
        {
            if (Min >= n) return Count;
            if (Max < n) return 0;
            return
                (Left == null ? 0 : Left.Search(n)) +
                (Right == null ? 0 : Right.Search(n));
        }
    }
}
// @lc code=end

