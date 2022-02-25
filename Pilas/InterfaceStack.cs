namespace EstructurasDeDatos.Pilas
{
    interface IStack<T>
    {
        public void Push(T value);  // 1
        public T Pop(); // 1
        public T Top(); // 1
        public bool IsEmpty(); // 1
    }
}
