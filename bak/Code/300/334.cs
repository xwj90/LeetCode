using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public partial class Solution
{
	public bool IncreasingTriplet(int[] nums)
	{
		int c1 = int.MaxValue;
		int c2 = int.MaxValue;
		foreach (var x in nums)
		{
			if (x <= c1)
				c1 = x;
			else if (x <= c2)
				c2 = x;
			else
				return true;
		}

		return false;
	}
}