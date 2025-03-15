namespace app.CommonAlgorithms.Graph;
using System;
using System.Collections.Generic;

public class Dijkstra
{
    private int[,] graph;
    private int verticesCount;

    public Dijkstra(int[,] adjacencyMatrix)
    {
        this.graph = adjacencyMatrix;
        this.verticesCount = adjacencyMatrix.GetLength(0);
    }

    public List<int> FindShortestPath(int source, int target)
    {
        int[] distances = new int[verticesCount];
        int[] previous = new int[verticesCount];
        bool[] visited = new bool[verticesCount];
        List<int> path = new List<int>();

        for (int i = 0; i < verticesCount; i++)
        {
            distances[i] = int.MaxValue;
            previous[i] = -1;
            visited[i] = false;
        }

        distances[source] = 0;

        while (!visited[target])
        {
            int u = MinimumDistance(distances, visited);
            visited[u] = true;

            for (int v = 0; v < verticesCount; v++)
            {
                if (!visited[v] && graph[u, v] != 0 && distances[u] != Int32.MaxValue && 
                    distances[u] + graph[u, v] < distances[v])
                {
                    distances[v] = distances[u] + graph[u, v];
                    previous[v] = u;
                }
            }
        }

        int current = target;
        while (current != -1)
        {
            path.Insert(0, current);
            current = previous[current];
        }

        return path;
    }

    private int MinimumDistance(int[] distances, bool[] visited)
    {
        int min = int.MaxValue;
        int minIndex = -1;

        for (int v = 0; v < verticesCount; v++)
        {
            if (!visited[v] && distances[v] <= min)
            {
                min = distances[v];
                minIndex = v;
            }
        }

        return minIndex;
    }
    
}