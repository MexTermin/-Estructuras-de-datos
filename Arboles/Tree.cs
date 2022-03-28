namespace EstructurasDeDatos.Arboles
{
    abstract class Tree<T>
    {
        public T Root { get; set; }

        public Tree(T root)
        {
            this.Root = root;
        }

        public abstract T IsLeaf();
        public abstract T DeGree();
        public abstract T Height();
    }
}
