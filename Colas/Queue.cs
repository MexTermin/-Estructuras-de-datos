namespace EstructurasDeDatos.Colas
{
    interface Queue<T>
    {
        public bool isEmpty();
        public void enQueue(dynamic value);
        public dynamic deQueue();
        public T head();
        public T tail();
    }
}
