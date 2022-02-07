using System;

namespace EstructurasDeDatos
{
    class Program
    {
        static void Main()
        {
            Colas.PriorityLinkedQueue<dynamic> cola = new();
            cola.EnQueue("yael", 3);
            cola.EnQueue("demil", 2);
            cola.EnQueue("medina", 1);
            cola.EnQueue("medina polanco");
            Console.WriteLine(cola.DeQueue());
            Console.WriteLine(cola.DeQueue());
            Console.WriteLine(cola.DeQueue());
            Console.WriteLine(cola.Tail());
            Console.ReadKey();
        }
    }
}

// yael -> medina -> demil -> medina polanco