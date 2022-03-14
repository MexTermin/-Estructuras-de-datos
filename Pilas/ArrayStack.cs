using System;
using EstructurasDeDatos.Utils;
namespace EstructurasDeDatos.Pilas
{
    public class ArrayStack<T>
    {
        protected T[] Children { get; set; }
        protected int Size { get; set; }

        public ArrayStack(int startSize = 10) //1
        {
            this.Children = new T[startSize]; //  1
        }

        // O(1)
        public bool IsEmpty()
        {
            return this.Size == 0; // 1
        }

        // O(n)
        public void Push(T value)
        {
            if (this.Size == this.Children.Length) // 1
            {
                this.Children = Helpers.Arrays<T>.ResizeArray(this.Children, this.Children.Length * 2, this.Size - 1); // O(n)
            }
            this.Children[this.Size] = value; // 1
            this.Size++; // 1
        }


        public T Pop()
        {
            if (this.IsEmpty()) throw new Exception("La pila está vacía");// 1
            if (this.Children.Length / 2 > this.Size) // 1
            {
                this.Children = Helpers.Arrays<T>.ResizeArray(this.Children, this.Size * 2, this.Size - 1); // O(n)
            }

            T result = this.Children[this.Size - 1];// 1
            this.Children[this.Size - 1] = default; // 1
            this.Size--;
            return result; // 1
        }

        // O(1)
        public T Top()
        {
            if (this.IsEmpty()) throw new Exception("La pila está vacía");// 1
            return this.Children[this.Size - 1]; //1
        }
    }
}
