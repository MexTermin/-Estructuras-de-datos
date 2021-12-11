namespace EstructurasDeDatos.Utils
{
    class SimpleNode<T>
    {
        private dynamic value { get; set; }
        private T next { get; set; }
        private int priority { get; set; }

        public void setNext(T value)
        {
            this.next = value;
        }

        public T getNext()
        {
            return this.next;
        }

        public void setValue(dynamic value)
        {
            this.value = value;
        }

        public dynamic getValue()
        {
            return this.value;
        }

        public void setPiority(int value)
        {
            this.priority = value;
        }

        public int getPriority()
        {
            return this.priority;
        }
    }
    class SimpleNode : SimpleNode<SimpleNode> { }
}

