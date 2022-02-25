using System;

namespace EstructurasDeDatos
{
    class Program
    {
        static void Main()
        {
            Pilas.ArrayStack<string>  lista = new();
            lista.Push("a");
            lista.Push("b");
            lista.Push("c");
            lista.Push("d");
            lista.Pop();
            Console.WriteLine(lista.Top());
            // Console.ReadKey();
        }
    }
}

// medina -> demil -> medina polanco -> yael