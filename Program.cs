using System;

namespace EstructurasDeDatos
{
    class Program
    {
        static void Main()
        {
            Colas.PriorityLinkedQueue<dynamic> cola = new();
            cola.EnQueue("yael", 5);
            cola.EnQueue("demil", 2);
            cola.EnQueue("medina", 1);
            cola.EnQueue("medina polanco", 2);
            cola.EnQueue("medina polanco 2", 4);
            cola.EnQueue("medina polanco 3", 1);
            Console.WriteLine(cola.DeQueue());
            Console.WriteLine(cola.DeQueue());
            Console.WriteLine(cola.DeQueue());
            Console.WriteLine(cola.DeQueue());
            Console.WriteLine(cola.DeQueue());
            Console.WriteLine(cola.Tail());
            // Console.ReadKey();
        }
    }
}

// medina -> demil -> medina polanco -> yael