using System.Collections.Generic;

namespace Ventus
{
    public class Graph<T>
    {
        private readonly List<T> nodes = new List<T>();
        private readonly List<Edge<T>> edges = new List<Edge<T>>();

        public List<T> Nodes
        {
            get { return nodes; }
        }

        public List<Edge<T>> Edges
        {
            get { return edges; }
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
            Edges.Add(new Edge<T>(x, y));
        }

        public void Remove(T x)
        {
            edges.RemoveAll(e => e.X.Equals(x) || e.Y.Equals(x));
            nodes.RemoveAll(n => n.Equals(x));
        }

        public void Remove(T x, T y)
        {
            edges.RemoveAll(e => e.X.Equals(x) && e.Y.Equals(y));
        }
    }
}
