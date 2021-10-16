using System;

namespace Ventus
{
    class Program
    {
        static void Main()
        {
            Print(Integrate(x => 1, 0, 10));
            Print(Integrate(x => x, 0, 10));
            Print(Integrate(x => x * x, 0, 10));
            Print(Integrate(x => Math.Abs(Math.Cos(x)), 0, 2));
            Print(Integrate(x => Math.Exp(x), 0, Math.PI));
        }

        private static void Print(double y)
        {
            Console.WriteLine("{0:0.0000}", y);
        }

        private static double Integrate(Func<double, double> f, double a, double b)
        {
            var sum = 0.0;
            var dx = (b - a) / 1e5;
            for (var x = a; x < b; x += dx)
                sum += f(x) + f(x + dx);
            return sum * dx / 2;
        }
    }
}
