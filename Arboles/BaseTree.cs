namespace EstructurasDeDatos.Arboles
{
    abstract class BaseTree<T>
    {
        T root { get; set; }

        public BaseTree(T root)
        {
            this.root = root;
        }

        public abstract T IsLeaf();
        public abstract T DeGree();
        public abstract T Height();
    }
}
