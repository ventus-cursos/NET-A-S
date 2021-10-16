using System.Collections.Generic;

namespace Ventus
{
    public class Graph<T>
    {
        private readonly List<T> nodes = new List<T>();
        private readonly bool[,] matrix;

        public Graph(int capacity = 10)
        {
            matrix = new bool[capacity, capacity];
        }

        public List<T> Nodes
        {
            get { return nodes; }
        }

        public List<Edge<T>> Edges
        {
            get
            {
                var list = new List<Edge<T>>();
                for (var i = 0; i < nodes.Count; i++)
                    for (var j = 0; j < nodes.Count; j++)
                        if (matrix[i, j]) list.Add(new Edge<T>(nodes[i], nodes[j]));
                return list;
            }
        }

        public void Add(T x)
        {
            if (!Nodes.Contains(x))
                Nodes.Add(x);
        }

        public void Add(T x, T y)
        {
            Add(x);
            Add(y);
            matrix[nodes.IndexOf(x), nodes.IndexOf(y)] = true;
        }

        public void Remove(T x)
        {
            var k = nodes.IndexOf(x);
            for (var i = 0; i < nodes.Count - 1; i++)
                for (var j = 0; j < nodes.Count - 1; j++)
                    if (i >= k || j >= k)
                        matrix[i, j] = matrix[i >= k ? i + 1 : i, j >= k ? j + 1 : j];
            nodes.RemoveAll(n => n.Equals(x));
        }

        public void Remove(T x, T y)
        {
            matrix[nodes.IndexOf(x), nodes.IndexOf(y)] = false;
        }
    }
}
