using System;
using System.Collections.Generic;

namespace Ventus
{
    static class Program
    {
        static void Main()
        {
            var r = new Random();
            var list = new SortedList<int, int>();

            var t = DateTime.Now;
            for (var i = 0; i < 10000; i++)
            {
                var x = r.Next();
                list.Add(x, x);
            }
            Console.WriteLine("Ordenado en {0}ms", (DateTime.Now - t).TotalMilliseconds);
            Console.ReadLine();

            foreach (var x in list.Keys)
                Console.WriteLine(x);
        }
    }
}
