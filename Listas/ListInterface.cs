namespace EstructurasDeDatos.Listas
{
    interface IList<T>
    {
        public void Add(T value);
        public void Delete(int index);
        public void Insert(int index, T value);
        public T Get(int index);
        public int Length();
    }
}
