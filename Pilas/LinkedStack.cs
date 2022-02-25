using EstructurasDeDatos.Utils;
using System;

namespace EstructurasDeDatos.Pilas
{
    internal class LinkedStack<T>: IStack<T>
    {
        protected SimpleLinkedNode<T> Head { get; set; } // 1

        // O(1)
        public bool IsEmpty()
        {
            return Head == null; // 1
        }

        // O(1)
        public void Push(T value)
        {
            SimpleLinkedNode<T> node = new (); // 1
            node.Value = value; // 1
            if (!this.IsEmpty()) // 1
            {
                node.Next = this.Head; // 1
            }
            this.Head = node; // 1
        }

        public T Pop()
        {
            if (this.IsEmpty()) throw new Exception("La pila está vacía"); // 1
            T value = this.Head.Value; // 1
            this.Head = this.Head.Next; // 1
            return value; // 1
        }

        // O(1)
        public T Top()
        {
            if (this.IsEmpty()) throw new Exception("La pila está vacía"); // 1
            return this.Head.Value; // 1
        }
    }
}
