using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public partial class Solution
{
	public int[] SmallestRange(IList<IList<int>> nums)
	{
		List<Tuple<int, int>> sort = new List<Tuple<int, int>>();
		for (int i = 0; i < nums.Count; i++)
			SmallestRange_Insert(sort, nums[i][0], i);

		int[] result = new int[] { sort[0].Item1, sort[sort.Count - 1].Item1 };
		int[] ids = new int[nums.Count];

		int groupId = sort[0].Item2;
		int id = ++ids[groupId];
		while (id < nums[groupId].Count)
		{
			sort.RemoveAt(0);
			SmallestRange_Insert(sort, nums[groupId][id], groupId);
			if ((sort[sort.Count - 1].Item1 - sort[0].Item1) < (result[1] - result[0]))
				result = new int[] { sort[0].Item1, sort[sort.Count - 1].Item1 };
			groupId = sort[0].Item2;
			id = ++ids[groupId];
		}
		return result;
	}
	public void SmallestRange_Insert(List<Tuple<int, int>> list, int value, int groupId)
	{
		if (list.Count == 0 || value >= list[list.Count - 1].Item1)
		{
			list.Add(new Tuple<int, int>(value, groupId));
		}
		else
		{
			int left = 0;
			int right = list.Count - 1;
			var mid = 0;
			while (left < right)
			{
				mid = (left + right) / 2;
				if (value > list[mid].Item1)
					left = mid + 1;
				else if (value < list[mid].Item1)
					right = mid;
				else
				{
					left = mid;
					break;
				}
			}
			list.Insert(left, new Tuple<int, int>(value, groupId));
		}
	}


}