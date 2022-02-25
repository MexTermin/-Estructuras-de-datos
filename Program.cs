using System;

namespace EstructurasDeDatos
{
    class Program
    {
        static void Main()
        {
            Listas.LinkedList<string>  lista= new();
            lista.Add("a");
            lista.Add("b");
            lista.Add("c");
            lista.Add("d");
            lista.Delete(0);
            lista.Insert(0,"1");
            Console.WriteLine(lista.Get(0));
            // Console.ReadKey();
        }
    }
}

// medina -> demil -> medina polanco -> yael