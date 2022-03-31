public class Solution
{
    public bool CanFinish(int numCourses, int[][] prerequisites)
    {
        var matrix = new int[numCourses][];
        for (var i = 0; i < numCourses; i++)
            matrix[i] = new int[numCourses];
        var indegree = new int[numCourses];

        foreach (var pair in prerequisites)
        {
            var ready = pair[0];
            var pre = pair[1];
            if (matrix[pre][ready] == 0) indegree[ready]++;
            matrix[pre][ready] = 1;
        }

        int count = 0;
        var q = new Queue<int>();
        for (var i = 0; i < indegree.Length; i++)
            if (indegree[i] == 0) q.Enqueue(i); //here are roots

        while (q.Any())
        {
            var course = q.Dequeue();
            count++;
            for (var i = 0; i < numCourses; i++)
            {
                if (matrix[course][i] != 0)
                {
                    indegree[i]--;
                    if (indegree[i] == 0)
                    {
                        q.Enqueue(i);
                    }
                }
            }
        }
        return count == numCourses;

    }
}
// @lc code=end

