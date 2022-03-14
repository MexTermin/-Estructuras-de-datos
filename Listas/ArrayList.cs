using System;
using EstructurasDeDatos.Utils;

namespace EstructurasDeDatos.Listas
{
    class ArrayList<T> : IList<T>
    {
        private int Len { get; set; }
        private T[] Children { get; set; }

        public ArrayList(int startSize = 10)
        {
            this.Children = new T[startSize]; // 1
        }

        // Time Complexity: O(n)
        public void Add(T value)
        {
            if (this.Children.Length == this.Len) // 1
            {
                this.Children = Helpers.Arrays<T>.ResizeArray(this.Children, this.Len * 2, this.Len-- ); // n
            }
            this.Children[this.Len] = value; // 1
            this.Len++; // 1
        }

        // Time  Complexity: O(n)
        public void Delete(int index)
        {
            if (index >= this.Len || index < 0) throw new Exception("Índice fuera de rango"); // 1
            for (var i = index; i < this.Len - 1; i++) // n
            {
                this.Children[i] = this.Children[i + 1]; // 1
            }
            if (this.Children.Length / 2 > this.Len) // 1
            {
                this.Children = Helpers.Arrays<T>.ResizeArray(this.Children, this.Len / 2, this.Len--); // 1
            }
            this.Len--; // 1
        }

        // Time Complexity: O(n)
        public void Insert(int index, T value)
        {
            if (index >= this.Len || index < 0) throw new Exception("Índice fuera de rango"); // 1

            if (this.Children.Length == this.Len) // 1
            {
                this.Children = Helpers.Arrays<T>.ResizeArray(this.Children, this.Len * 2, this.Len--); // 1
            }

            for (var i = this.Len; i > index; i--) // n
            {
                this.Children[i] = this.Children[i - 1]; // 1
            }
            this.Children[index] = value; // 1
            this.Len++; // 1
        }

        // Time Complexity: O(1)
        public T Get(int index)
        {
            if (index >= this.Len || index < 0) throw new Exception("Índice fuera de rango"); // 1
            return this.Children[index]; // 1
        }

        //Time Complexity: O(1)
        public int Length()
        {
            return this.Len; // 1
        }
    }
}
