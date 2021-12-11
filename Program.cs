using System;

namespace EstructurasDeDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            Colas.ArrayQueue<dynamic> cola = new();
            cola.enQueue("yael");
            cola.enQueue("demil");
            cola.enQueue("medina");
            Console.WriteLine(cola.deQueue());
            Console.WriteLine(cola.deQueue());
            Console.WriteLine(cola.head());
        }
    }
}
