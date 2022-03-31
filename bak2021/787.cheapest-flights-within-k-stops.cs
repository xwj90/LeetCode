/*
 * @lc app=leetcode id=787 lang=csharp
 *
 * [787] Cheapest Flights Within K Stops
 */
public class Solution
{


    public int FindCheapestPrice(int n, int[][] flights, int src, int dst, int K)
    {
        int[][] dist = new int[2][];
        dist[0] = new int[n];
        dist[1] = new int[n];
        int INF = Int32.MaxValue / 2;
        for (var i = 0; i < n; i++)
        {            
            dist[0][i] = INF;
            dist[1][i] = INF;
        }
        dist[0][src] = dist[1][src] = 0;

        for (int i = 0; i <= K; ++i)
            foreach (int[] edge in flights)
                dist[i & 1][edge[1]] = Math.Min(dist[i & 1][edge[1]], dist[~i & 1][edge[0]] + edge[2]);

        return dist[K & 1][dst] < INF ? dist[K & 1][dst] : -1;

    }
}

