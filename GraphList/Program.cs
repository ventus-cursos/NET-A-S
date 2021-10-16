using System.IO;

namespace Ventus
{
    static class Program
    {
        static void Main()
        {
            var graph = new Graph<string>();
            graph.Add("Cliente", "Ciudad");
            graph.Add("Ciudad", "Estado");
            graph.Add("Cliente", "Tipo");
            graph.Add("Orden", "Cliente");
            graph.Add("Orden", "Empleado");
            graph.Add("OrdenDetalle", "Orden");
            graph.Add("OrdenDetalle", "Producto");
            ExportChart(graph, "graph.tgf");
        }

        private static void ExportChart(Graph<string> graph, string file)
        {
            var f = File.CreateText(file);
            var nodes = graph.Nodes;
            var i = 1;
            foreach (var node in nodes)
                f.WriteLine("{0} {1}", i++, node);
            f.WriteLine("#");
            foreach (var edge in graph.Edges)
                f.WriteLine("{0} {1}", nodes.IndexOf(edge.X) + 1, nodes.IndexOf(edge.Y) + 1);
            f.Close();
        }
    }
}
