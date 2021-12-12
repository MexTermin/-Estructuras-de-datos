using System;

namespace EstructurasDeDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            Colas.PriorityLinkedQueue cola = new();
            cola.enQueue("yael", 3);
            cola.enQueue("demil", 2);
            cola.enQueue("medina");
            cola.enQueue("medina polanco");
            Console.WriteLine(cola.deQueue());
            Console.WriteLine(cola.deQueue());
            Console.WriteLine(cola.tail());
        }
    }
}
