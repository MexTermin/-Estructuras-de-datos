namespace EstructurasDeDatos.Colas
{
    class PriorityLinkedQueue : LinkedQueue
    {

        // Time Complexity: O(n)
        public void enQueue(dynamic value, int priority = 0)
        {
            Utils.SimpleNode node = new(); // 1
            node.setValue(value); // 1
            node.setPiority(priority); // 1

            if (this.isEmpty()) // 1
            {
                this.header = node; // 1
                this.queue = node; // 1
            }
            else
            {
                Utils.SimpleNode nodeActual; // 1
                if (this.queue.getPriority() >= priority) // 1
                {
                    this.queue.setNext(node); // 1
                    this.queue = node; // 1
                }
                else
                {
                    nodeActual = this.header; // 1
                    while (nodeActual.getPriority() > priority) // n
                    {
                        if (nodeActual.getNext() != null) // 1
                        {
                            nodeActual = nodeActual.getNext(); // 1
                            continue; // 1
                        }
                        break; // 1
                    }

                    // Se ejecuta cuando el elemento a insertar tiene mayor prioridad que el que va a la cabeza.
                    if (nodeActual.getPriority() < priority) // 1
                    {
                        node.setNext(nodeActual); // 1
                        this.header = node; // 1
                    }
                    else
                    {
                        node.setNext(nodeActual.getNext()); // 1
                        nodeActual.setNext(node); // 1
                    }
                }

            }
        }
    }
}
