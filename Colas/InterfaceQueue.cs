namespace EstructurasDeDatos.Colas
{
    interface IQueue<T>
    {
        public bool IsEmpty();
        public void EnQueue(T value);
        public T DeQueue();
        public T Head();
        public T Tail();
    }
}
