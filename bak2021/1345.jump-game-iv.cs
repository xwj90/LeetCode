public class Solution
{
    public int MinJumps(int[] arr)
    {
        var visited = new int[arr.Length];
        var map = new Dictionary<int, List<int>>();
        visited[0] = 1;
        for (var i = 0; i < arr.Length; i++)
        {
            if (!map.ContainsKey(arr[i])) map[arr[i]] = new List<int>() { i };
            else map[arr[i]].Add(i);
        }
        var jump = 0;
        var list = new List<int>() { 0 };
        while (list.Any())
        {
            var newList = new List<int>();
            foreach (var i in list)
            {
                if (i == arr.Length - 1) return jump;
                var temp = map[arr[i]];
                temp.Add(i - 1);
                temp.Add(i + 1);
                foreach (var j in temp)
                {
                    if (j >= 0 && j < arr.Length && visited[j] == 0)
                    {
                        visited[j]=1;
                        newList.Add(j);
                    }
                }
                temp.Clear();
            }
            list = newList;
            jump++;
        }

        return jump;
    }
}
// @lc code=end

