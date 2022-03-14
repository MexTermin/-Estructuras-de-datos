namespace EstructurasDeDatos.Utils
{    class DoubleLinkedNode<T> : SimpleLinkedNode<T>
    {
        public DoubleLinkedNode<T> Previus { get; set; }
        public DoubleLinkedNode(T value, SimpleLinkedNode<T> next = null, DoubleLinkedNode<T> previous = null) : base(value, next)
        {
            this.Previus = previous;
        }
    }
}
