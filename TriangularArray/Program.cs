using System;

namespace Ventus
{
    static class Program
    {
        static void Main()
        {
            Test1();
        }

        private static void Test1()
        {
            const int side = 20;
            var a = new TriangularArray<int>(side);
            for (var i = 0; i < side; i++)
                a[i, i] = 1;

            for (var i = 0; i < side; i++)
            {
                for (var j = 0; j <= i; j++)
                    Console.Write("[{0}] ", a[i, j]);
                Console.WriteLine();
            }
        }
    }
}