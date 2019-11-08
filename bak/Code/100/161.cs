
using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
	public bool IsOneEditDistance(string s, string t)
	{
		for (int i = 0; i < Math.Min(s.Length, t.Length); i++)
		{
			if (s[i] != t[i])
				if (s.Length == t.Length)
					return s.Substring(i + 1) == t.Substring(i + 1);
				else if (s.Length < t.Length)
					return s.Substring(i) == t.Substring(i + 1);
				else
					return s.Substring(i + 1) == t.Substring(i);
		}
		return Math.Abs(t.Length - s.Length) == 1;
	}
}