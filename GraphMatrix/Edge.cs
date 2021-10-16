namespace Ventus
{
    public class Edge<T>
    {
        public T X { get; set; }
        public T Y { get; set; }

        public Edge(T x, T y)
        {
            X = x;
            Y = y;
        }
    }
}