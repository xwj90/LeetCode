using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{

    public IList<TreeNode> GenerateTrees(int n)
    {
        if (n <= 0)
            return new List<TreeNode>();
        Dictionary<Tuple<int, int>, List<TreeNode>> cache = new Dictionary<Tuple<int, int>, List<TreeNode>>();
        return GenerateTrees(1, n, cache);
    }
    private IList<TreeNode> GenerateTrees(int min, int max, Dictionary<Tuple<int, int>, List<TreeNode>> cache)
    {
        var key = new Tuple<int, int>(min, max);
        if (cache.ContainsKey(key))
            return cache[key];
        var result = new List<TreeNode>();
        if (min > max)
            return new List<TreeNode>() { null };
        if (min == max)
            return new List<TreeNode>() { new TreeNode(min) };

        for (int i = min; i <= max; i++)
        {
            foreach (var left in GenerateTrees(min, i - 1, cache))//left
                foreach (var right in GenerateTrees(i + 1, max, cache))//left
                {
                    var node = new TreeNode(i);
                    node.left = left;
                    node.right = right;
                    result.Add(node);
                }
        }
        cache[key] = result;
        return result;
    }
}