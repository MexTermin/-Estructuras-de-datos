using System;
using utils = EstructurasDeDatos.Utils.Utils;

namespace EstructurasDeDatos.Colas
{
    class ArrayQueue<T> : Queue<T>
    {
        private dynamic[] children { get; set; }
        private int lastPosition { get; set; }
        private utils.Arrays<dynamic> uArrays = new();

        public ArrayQueue()
        {
            this.children = new dynamic[10];
        }

        // Time Complexity: O(1)
        public bool isEmpty()
        {
            return this.children.Length == 0; // 1
        }

        // Time Complexity: O(n)
        public void enQueue(dynamic value)
        {
            if (this.lastPosition == this.children.Length) // 1
            {
                this.children = uArrays.resizeArray(this.children, this.children.Length * 2, this.lastPosition - 1); // n
            }
            this.children[this.lastPosition] = value; // 1
            this.lastPosition++;                      // 1
        }

        // Time Complexity: O(n)
        public dynamic deQueue()
        {
            if (this.isEmpty()) // 1
            {
                throw new Exception("La cola está vacía"); // 1
            }
            var result = this.children[0];                           // 1

            for (var index = 0; index < this.lastPosition - 1; index++)// n
            {
                this.children[index] = this.children[index + 1]; // 1
            }
            if (this.children.Length / 2 > this.lastPosition && this.lastPosition > 10)// 1
            {
                this.children = uArrays.resizeArray(this.children, this.lastPosition * 2, this.lastPosition - 1); // n
            }

            this.children[this.lastPosition - 1] = null; // 1
            this.lastPosition--;                    // 1
            return result;                              // 1
        }

        // Time Complexity: O(1)
        public T head()
        {
            if (this.isEmpty()) // 1
            {
                throw new Exception("La cola está vacía"); // 1
            }
            return this.children[0]; // 1
        }

        // Time Complexity: O(1)
        public T tail()
        {
            if (this.isEmpty()) // 1
            {
                throw new Exception("La cola está vacía"); // 1
            }
            return this.children[this.lastPosition - 1]; // 1
        }
    }
}
