namespace EstructurasDeDatos.Colas
{
    interface InterfaceQueue
    {
        public bool isEmpty();
        public void enQueue(dynamic value);
        public dynamic deQueue();
        public dynamic head();
        public dynamic tail();
    }
}
