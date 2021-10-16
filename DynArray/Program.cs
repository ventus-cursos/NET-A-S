using System;
using System.Collections.Generic;

namespace Ventus
{
    public static class Program
    {
        public static void Main()
        {
            Test1();
            Test2();
        }

        private static void Test1()
        {
            Console.WriteLine("Test 1");
            var r = new Random();
            var a = new DynArray<int>();
            var capacity = 0;
            for (var i = 0; i < 1000; i++)
            {
                a.Add(r.Next());
                if (a.Capacity != capacity)
                {
                    capacity = a.Capacity;
                    Console.WriteLine(capacity);
                }
            }
            Console.WriteLine();
        }

        private static void Test2()
        {
            Console.WriteLine("Test 2");
            var r = new Random();
            var a = new List<int>();
            var capacity = 0;
            for (var i = 0; i < 1000; i++)
            {
                a.Add(r.Next());
                if (a.Capacity != capacity)
                {
                    capacity = a.Capacity;
                    Console.WriteLine(capacity);
                }
            }
            Console.WriteLine();
        }
    }
}
