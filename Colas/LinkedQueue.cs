using System;

namespace EstructurasDeDatos.Colas
{
    class LinkedQueue : Queue<Utils.SimpleNode>
    {
        private Utils.SimpleNode header { get; set; }
        private Utils.SimpleNode queue { get; set; }

        // O(1)
        public bool isEmpty()
        {
            return this.header == null; // 1
        }

        // Time Complexity: O(1)
        public void enQueue(dynamic value)
        {
            Utils.SimpleNode node = new(); // 1
            node.setValue(value); // 1

            if (this.header == null) // 1
            {
                this.header = node; // 1
                this.queue = node; // 1
            }
            else
            {
                this.queue.setNext(node); // 1
                this.queue = node; // 1
            }
        }

        // Time Complexity: O(1)
        public dynamic deQueue()
        {
            if (this.isEmpty()) // 1
            {
                throw new Exception("La cola está vacía"); // 1
            }
            var result = this.header.getValue(); // 1
            this.header = this.header.getNext(); // 1

            if (this.header == null) // 1
            {
                this.queue = null; // 1
            }
            return result; // 1
        }

        // Time Complexity: O(1)
        public Utils.SimpleNode head()
        {
            return this.header; // 1
        }

        // Time Complexity: O(1)
        public Utils.SimpleNode tail()
        {
            return this.queue; // 1
        }
    }
}
