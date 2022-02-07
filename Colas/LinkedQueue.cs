using System;

namespace EstructurasDeDatos.Colas
{
    class LinkedQueue<T> : IQueue<T>
    {
        protected Utils.SimpleLinkedNode<T> Header { get; set; }
        protected Utils.SimpleLinkedNode<T> Queue { get; set; }

        // O(1)
        public bool IsEmpty()
        {
            return this.Header == null; // 1
        }

        // Time Complexity: O(1)
        public void EnQueue(T value)
        {
            Utils.SimpleLinkedNode<T> node = new(); // 1
            node.Value = value; // 1

            if (this.Header == null) // 1
            {
                this.Header = node; // 1
                this.Queue = node; // 1
            }
            else
            {
                this.Queue.Next = node; // 1
                this.Queue = node; // 1
            }
        }

        // Time Complexity: O(1)
        public T DeQueue()
        {
            if (this.IsEmpty()) // 1
            {
                throw new Exception("La cola está vacía"); // 1
            }
            var result = this.Header.Value; // 1
            this.Header = this.Header.Next; // 1

            if (this.Header == null) // 1
            {
                this.Queue = null; // 1
            }
            return result; // 1
        }

        // Time Complexity: O(1)
        public T Head()
        {
            return this.Header.Value; // 1
        }

        // Time Complexity: O(1)
        public T Tail()
        {
            return this.Queue.Value; // 1
        }
    }
}
