using System;
using System.Collections.Generic;

namespace Ventus
{
    class Program
    {
        static void Main()
        {
            const int N = 10000;
            var A = new HashSet<int>();
            var r = new Random();
            for (var i = 0; i < N; i++)
            {
                var x = r.Next(N);
                A.Add(x);
            }

            foreach (var x in A)
                Console.Write(x + " ");

            for (var i = 0; i < 10; i++)
            {
                var x = r.Next(N);
                if (A.Contains(x))
                    Console.WriteLine("A contiene {0}", x);
                else
                    Console.WriteLine("A no contiene {0}", x);
            }

            //TODO: A.UnionWith(B); A.IntersectWith(B);
        }
    }
}
