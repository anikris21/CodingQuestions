using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingQuestions.Graph.Graph
{
    public class Graph
    {
        int v;

        List<int>[] adj;

        public Graph(int vertices)
        {
            v = vertices;
            adj = new List<int>[vertices];

            for (int i = 0; i < adj.Length; i++)
            {
                adj[i] = new List<int>();
            }
        }

        public void addEdge(int u, int v)
        {
            adj[u].Add(v);
        }

        public void Print()
        {
            for (int i = 0; i < adj.Length; i++)
            {
                Console.WriteLine($"vertex {i}");
                foreach (int v in adj[i])
                {
                    Console.Write($"{v}  ");
                }
            }
        }
    }


}
