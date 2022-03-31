public class NestedIterator
{

    private Stack<NestedInteger> stack = new Stack<NestedInteger>();
    public NestedIterator(IList<NestedInteger> nestedList)
    {
        for (var i = nestedList.Count - 1; i >= 0; i--)
            stack.Push(nestedList[i]);
    }

    public bool HasNext()
    {
        while (this.stack.Any())
        {
            var cur = this.stack.Peek();
            if (cur.IsInteger()) return true;
            this.stack.Pop();
            var list = cur.GetList();
            for (var i = list.Count - 1; i >= 0; i--)
            {
                stack.Push(list[i]);
            }
        }
        return false;

    }

    public int Next()
    {
        return this.stack.Pop().GetInteger();
    }
}

/**
 * Your NestedIterator will be called like this:
 * NestedIterator i = new NestedIterator(nestedList);
 * while (i.HasNext()) v[f()] = i.Next();
 */
// @lc code=end

/*
 * @lc app=leetcode id=341 lang=csharp
 *
 * [341] Flatten Nested List Iterator
 */

// @lc code=start
/**
 * // This is the interface that allows for creating nested lists.
 * // You should not implement it, or speculate about its implementation
 * interface NestedInteger {
 *
 *     // @return true if this NestedInteger holds a single integer, rather than a nested list.
 *     bool IsInteger();
 *
 *     // @return the single integer that this NestedInteger holds, if it holds a single integer
 *     // Return null if this NestedInteger holds a nested list
 *     int GetInteger();
 *
 *     // @return the nested list that this NestedInteger holds, if it holds a nested list
 *     // Return null if this NestedInteger holds a single integer
 *     IList<NestedInteger> GetList();
 * }
 */
