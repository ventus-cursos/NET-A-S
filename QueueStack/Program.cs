using System;
using System.Collections.Generic;

namespace Ventus
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("QUEUE");
            Console.WriteLine("=====");
            var fila = new Queue<string>();
            fila.Enqueue("Esta");
            fila.Enqueue("es");
            fila.Enqueue("una");
            fila.Enqueue("prueba");
            while (fila.Count != 0)
                Console.WriteLine(fila.Dequeue());

            Console.WriteLine();

            Console.WriteLine("STACK");
            Console.WriteLine("=====");
            var pila = new Stack<string>();
            pila.Push("Esta");
            pila.Push("es");
            pila.Push("una");
            pila.Push("prueba");
            while (pila.Count != 0)
                Console.WriteLine(pila.Pop());
        }
    }
}
