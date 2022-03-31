public class Solution
{
    public int[] AdvantageCount(int[] A, int[] B)
    {
        var list1 = new List<(int value, int Id)>();
        var list2 = new List<(int value, int Id)>();
        for (var k = 0; k < A.Length; k++)
        {
            list2.Add((A[k], k));
            list2.Add((B[k], k));
        }
        list1.Sort();
        list2.Sort();

        var discard = new List<int>();
        var res = new List<int>();
        var i = 0;
        var j = 0;
        while (i < list1.Count)
        {
            if (list1[i].value > list2[j].value)
            {
                res.Add(list1[i].value);
                i++;
                j++;
            }
            else
            {
                discard.Add(list1[i].value);
                i++;
            }
        }
        res.AddRange(discard);
        return res.ToArray();
    }
}
// @lc code=end

