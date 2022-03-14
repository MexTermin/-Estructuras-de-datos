namespace EstructurasDeDatos.Utils
{
    class SimpleLinkedNode<T>
    {
        public T Value { get; set; }
        public SimpleLinkedNode<T> Next { get; set; }

        public SimpleLinkedNode(T value, SimpleLinkedNode<T> next = null)
        {
            this.Value = value;
            this.Next = next;
        }
    }
}

