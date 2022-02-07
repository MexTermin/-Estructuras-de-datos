namespace EstructurasDeDatos.Colas
{
    class PriorityLinkedQueue<T> : LinkedQueue<T>
    {
        // Time Complexity: O(n)
        public void EnQueue(dynamic value, int priority = 0)
        {
            Utils.SimpleLinkedNode<T> node = new(); // 1
            node.Value = value; // 1

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
                    Utils.SimpleLinkedNode<T> temp = this.Header; // 1
                    int index = 1; // 1
                    while (temp.Next != null && priority > index) // n
                    {
                        temp = temp.Next; // 1
                        index++; // 1
                    }

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
