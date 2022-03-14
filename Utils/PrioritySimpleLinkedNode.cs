namespace EstructurasDeDatos.Utils
{
    class PrioritySimpleNode<T> : SimpleLinkedNode<T>
    {
        public int Priority { get; set; }
        public PrioritySimpleNode(T value, int priority, SimpleLinkedNode<T> next = null) : base(value, next)
        {
            this.Priority = priority;
        }
    }
}

