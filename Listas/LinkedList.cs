using EstructurasDeDatos.Utils;
using System;

namespace EstructurasDeDatos.Listas
{
    public class LinkedList<T> : IList<T>
    {
        private DoubleLinkedNode<T> Head { get; set; }
        private DoubleLinkedNode<T> Tail { get; set; }
        private int Len { get; set; }

        // O(1)
        public int Length()
        {
            return this.Len; // 1
        }

        // O(n)
        public T Get(int index)
        {
            if (index >= this.Len || index < 0) throw new Exception("Índice fuera de rango"); // 1
            if (index == 0) // 1
            {
                return this.Head.Value; // 1
            }
            else if (index == this.Len - 1) // 1
            {
                return this.Tail.Value; // 1
            }
            else
            {
                DoubleLinkedNode<T> node = this.Head; // 1
                for (int i = 0; i < index; i++) // n
                {
                    node = (DoubleLinkedNode<T>)node.Next; // 1
                }
                return node.Value; // 1
            }
        }

        // O(n)
        public void Delete(int index)
        {
            if (index >= this.Len || index < 0) throw new Exception("Índice fuera de rango"); // 1

            if (index == 0) // 1
            {
                this.Head = (DoubleLinkedNode<T>)this.Head.Next; // 1
                this.Head.Previus = null; // 1
            }
            else if (index == this.Len - 1) // 1
            {
                this.Tail = this.Tail.Previus; // 1
                this.Tail.Next = null; // 1
            }
            else
            {
                DoubleLinkedNode<T> node = this.Head; // 1
                for (int i = 0; i < index; i++) // n
                {
                    node = (DoubleLinkedNode<T>)node.Next; // 1
                }
                node.Previus.Next = node.Next; // 1
                ((DoubleLinkedNode<T>)node.Next).Previus = node.Previus; // 1
            }
            this.Len--; // 1
        }


        public void Insert(int index, T value)
        {
            if (index >= this.Len || index < 0) throw new Exception("Índice fuera de rango"); // 1

            DoubleLinkedNode<T> newNode = new(value); // 1
            if (index == 0) // 1
            {
                newNode.Next = this.Head; // 1
                this.Head.Previus = newNode; // 1
                this.Head = newNode; // 1
            }
            else if (index == this.Len - 1) // 1
            {
                newNode.Previus = this.Tail; // 1
                this.Tail.Next = newNode; // 1
                this.Tail = newNode; // 1
            }
            else
            {
                DoubleLinkedNode<T> node = this.Head;// 1
                for (int i = 0; i < index; i++) // n
                {
                    node = (DoubleLinkedNode<T>)node.Next; // 1
                }
                newNode.Next = node; // 1
                newNode.Previus = node.Previus; // 1
                node.Previus.Next = newNode; // 1
                node.Previus = newNode; // 1
            }

            this.Len++; // 1
        }

        public void Add(T value)
        {
            DoubleLinkedNode<T> newNode = new(value); // 1

            if (this.Head == null || this.Tail == null) // 1
            {
                this.Head = newNode; // 1
                this.Tail = newNode; // 1
            }
            else
            {
                newNode.Previus = this.Tail; // 1
                this.Tail.Next = newNode; // 1
                this.Tail = newNode; // 1
            }
            this.Len++; // 1
        }
    }
}