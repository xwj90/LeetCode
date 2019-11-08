using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
	public int MinSwapsCouples(int[] row)
	{
		var minSwap = 0;
		Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();
		for (int i = 0; i < row.Length; i += 2)
		{
			if (row[i] / 2 != row[i + 1] / 2)
			{
				if (!dict.ContainsKey(row[i] / 2))
					dict[row[i] / 2] = new List<int>();
				dict[row[i] / 2].Add(i / 2);
				if (!dict.ContainsKey(row[i + 1] / 2))
					dict[row[i + 1] / 2] = new List<int>();
				dict[row[i + 1] / 2].Add((i + 1) / 2);
			}
		}
		HashSet<Tuple<int, int>> hs = new HashSet<Tuple<int, int>>();
		foreach (var v in dict.Values)
		{
			var temp = v.OrderBy(p => p).ToArray();
			var key = new Tuple<int, int>(temp[0], temp[1]);
			if (hs.Contains(key))
			{
				minSwap++;
				hs.Remove(key);
			}
			else
				hs.Add(key);
		}
		return minSwap + (hs.Count == 0 ? 0 : hs.Count - 1);
	}
}
//[5,4,2,6,3,1,0,7]