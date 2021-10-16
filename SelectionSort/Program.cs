using System;

namespace Ventus
{
    public class Program
    {
        public static void Main()
        {
            var a = new int[10000];
            var r = new Random();
            for (var i = 0; i < a.Length; i++)
                a[i] = r.Next();

            var t = DateTime.Now;
            Util.SelectionSort(a);
            Console.WriteLine("Elapsed: {0} ms.", (DateTime.Now - t).TotalMilliseconds);
            Console.ReadLine();

            for (var i = 0; i < a.Length; i++)
                Console.WriteLine(a[i]);
            Console.ReadLine();
        }
    }
}