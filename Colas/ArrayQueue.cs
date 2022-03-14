using System;
using EstructurasDeDatos.Utils;

namespace EstructurasDeDatos.Colas
{
    class ArrayQueue<T> : IQueue<T>
    {
        private T[] Children { get; set; }
        private int LastPosition { get; set; }

        public ArrayQueue(int startSize = 10)
        {
            this.Children = new T[startSize]; // 1
        }

        // Time Complexity: O(1)
        public bool IsEmpty()
        {
            return this.Children.Length == 0; // 1
        }

        // Time Complexity: O(n)
        public void EnQueue(T value)
        {
            if (this.LastPosition == this.Children.Length) // 1
            {
                this.Children = Helpers.Arrays<T>.ResizeArray(this.Children, this.Children.Length * 2, this.LastPosition - 1); // n
            }
            this.Children[this.LastPosition] = value; // 1
            this.LastPosition++;                      // 1
        }

        // Time Complexity: O(n)
        public T DeQueue()
        {
            if (this.IsEmpty()) throw new Exception("La cola está vacía");
            var result = this.Children[0];                           // 1

            for (var index = 0; index < this.LastPosition - 1; index++) // n
            {
                this.Children[index] = this.Children[index + 1]; // 1
            }
            if (this.Children.Length / 2 > this.LastPosition)// 1
            {
                this.Children = Helpers.Arrays<T>.ResizeArray(this.Children, this.LastPosition / 2, this.LastPosition - 1); // n
            }

            this.Children[this.LastPosition - 1] = default; // 1
            this.LastPosition--;                    // 1
            return result;                              // 1
        }

        // Time Complexity: O(1)
        public T Head()
        {
            if (this.IsEmpty()) throw new Exception("La cola está vacía"); // 1
            return this.Children[0]; // 1
        }

        // Time Complexity: O(1)
        public T Tail()
        {
            if (this.IsEmpty()) throw new Exception("La cola está vacía"); // 1
            return this.Children[this.LastPosition - 1]; // 1
        }
    }
}
