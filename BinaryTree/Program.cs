using System;

namespace Ventus
{
    class Program
    {
        static void Main()
        {
            var r = new Random();
            var tree = new BinaryTree<int>();
            var t = DateTime.Now;
            for (var i = 0; i < 10000; i++)
                tree.Add(r.Next());
            Console.WriteLine("10,000 números ordenados en {0}ms. Oprime Enter.", (DateTime.Now - t).TotalMilliseconds);
            Console.ReadLine();

            tree.Traverse(o => Console.Write(o + " "));

            int n;
            while (ReadInt(out n))
            {
                if (tree.Find(n))
                    Console.WriteLine("Lo encontré.");
                else
                    Console.WriteLine("No lo encontré.");
            }
        }

        private static bool ReadInt(out int n)
        {
            n = 0;
            Console.Write("Dame un número: ");
            var s = Console.ReadLine();
            if (string.IsNullOrEmpty(s))
                return false;
            if (int.TryParse(s, out n))
                return true;
            Console.WriteLine("Eso no parece un numero entero.");
            return true;
        }
    }
}
