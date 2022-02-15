using System;
using EstructurasDeDatos.Utils;
namespace EstructurasDeDatos.Colas
{
    class PriorityLinkedQueue<T> : LinkedQueue<T>
    {
        // Time Complexity: O(n)
        public void EnQueue(dynamic value, int priority = 0)
        {
            PrioritySimpleNode<T> node = new(); // 1
            node.Value = value; // 1
            node.Priority = priority;

            if (this.IsEmpty()) // 1
            {
                this.Header = node; // 1
                this.Queue = node; // 1
            }
            else
            {
                if (priority == 0) // 1
                {
                    this.Queue.Next = node; // 1
                    this.Queue = node; // 1
                }
                else
                {
                    PrioritySimpleNode<T> castedHeader = (PrioritySimpleNode<T>)this.Header; // 1
                    PrioritySimpleNode<T> temp = castedHeader; // 1
                    while (temp.Next != null && priority >= ((PrioritySimpleNode<T>)temp.Next).Priority) // n
                    {
                        temp = (PrioritySimpleNode<T>)temp.Next; // 1
                    }

                    if (temp == castedHeader && temp.Priority > priority) // 1
                    {
                        node.Next = temp; //1
                        this.Header = node; // 1
                    }
                    else
                    {
                        if (temp.Next == null) // 1
                        {
                            this.Queue = node; // 1
                        }
                        node.Next = temp.Next; // 1
                        temp.Next = node; // 1
                    }
                }
            }
        }
    }
}
