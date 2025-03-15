using System;
using app.CommonAlgorithms.Graph;
using app.Graph;
using app.LinkedList;
using app.Tree;

namespace app
{
    internal static class Program
    {
        private static void Main()
        {
            int[,] graph =
            {
                { 0, 4, 0, 0, 0, 0, 0, 8, 0 }, // A
                { 4, 0, 8, 0, 0, 0, 0, 11, 0 }, // b
                { 0, 8, 0, 7, 0, 4, 0, 0, 2 }, // C
                { 0, 0, 7, 0, 9, 14, 0, 0, 0 }, // d
                { 0, 0, 0, 9, 0, 10, 0, 0, 0 }, // E
                { 0, 0, 4, 14, 10, 0, 2, 0, 0 }, // F
                { 0, 0, 0, 0, 0, 2, 0, 1, 6 }, // G
                { 8, 11, 0, 0, 0, 0, 1, 0, 7 }, // H
                { 0, 0, 2, 0, 0, 0, 6, 7, 0 } // I
            };

            Dijkstra _dijkstra = new Dijkstra(graph);
            var source = 0;
            var target = 4;

            List<int> shortestPath = _dijkstra.FindShortestPath(source, target);
            
            Console.WriteLine($"Shortest Path from the vertext {source} to vertext {target}");
            foreach (var vertext in shortestPath)
            {
                Console.WriteLine(vertext + " ");
            }
            Console.WriteLine();
        }

    }
}