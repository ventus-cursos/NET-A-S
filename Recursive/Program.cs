using System;
using System.Collections.Generic;

namespace Ventus
{
    internal class Program
    {
        private static void Main()
        {
            var r = new Random();

            var a = r.Next(1000) + 100;
            var b = r.Next(1000) + 100;
            Test1I(a, b);
            Test1R(a, b);

            var n = r.Next(10) + 20;
            Test2I(n);
            Test2R(n);

            n = 41;
            Test3I(n);
            Test3R(n);
            Test3O(n);
        }

        #region Test1

        private static void Test1I(int a, int b)
        {
            Console.WriteLine("MCD({0},{1}) = {2}", a, b, GreatestCommonDivisor_Iterative(a, b));
        }

        private static int GreatestCommonDivisor_Iterative(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                    a -= b;
                else if (b > a)
                    b -= a;
            }
            return a;
        }

        private static void Test1R(int a, int b)
        {
            Console.WriteLine("MCD({0},{1}) = {2}", a, b, GreatestCommonDivisor_Recursive(a, b));
        }

        private static int GreatestCommonDivisor_Recursive(int a, int b)
        {
            if (a > b)
                return GreatestCommonDivisor_Recursive(a - b, b);
            if (b > a)
                return GreatestCommonDivisor_Recursive(a, b - a);
            return a;
        }

        #endregion

        #region Test2

        private static void Test2I(int n)
        {
            Console.WriteLine("{0}! = {1:N0}", n, Factorial_Iterative(n));
        }

        private static decimal Factorial_Iterative(int n)
        {
            if (n < 2) return 1;
            var f = 1.0m;
            for (var i = 2; i <= n; i++)
                f *= i;
            return f;
        }

        private static void Test2R(int n)
        {
            Console.WriteLine("{0}! = {1:N0}", n, Factorial_Recursive(n));
        }

        private static decimal Factorial_Recursive(int n)
        {
            if (n < 2) return 1;
            return n * Factorial_Recursive(n - 1);
        }

        #endregion

        #region Test3

        private static void Test3I(int n)
        {
            var t = DateTime.Now;
            Console.WriteLine("F{0} = {1:N0} {2}ms", n, Fibonacci_Iterative(n), (DateTime.Now - t).TotalMilliseconds);
        }

        private static decimal Fibonacci_Iterative(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            decimal a = 0;
            decimal b = 1;
            decimal f = 0;
            for (var i = 2; i <= n; i++)
            {
                f = a + b;
                a = b;
                b = f;
            }
            return f;
        }

        private static void Test3R(int n)
        {
            var t = DateTime.Now;
            Console.WriteLine("F{0} = {1:N0} {2}ms", n, Fibonacci_Recursive(n), (DateTime.Now - t).TotalMilliseconds);
        }

        private static decimal Fibonacci_Recursive(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return Fibonacci_Recursive(n - 1) + Fibonacci_Recursive(n - 2);
        }

        private static void Test3O(int n)
        {
            var t = DateTime.Now;
            Console.WriteLine("F{0} = {1:N0} {2}ms", n, Fibonacci_RecursiveOpt(n), (DateTime.Now - t).TotalMilliseconds);
        }

        private static readonly Dictionary<int, decimal> Cache = new Dictionary<int, decimal>();

        private static decimal Fibonacci_RecursiveOpt(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            if (Cache.ContainsKey(n)) return Cache[n];
            var f = Fibonacci_RecursiveOpt(n - 1) + Fibonacci_RecursiveOpt(n - 2);
            Cache[n] = f;
            return f;
        }

        #endregion

    }
}
