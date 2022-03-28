using System;
namespace EstructurasDeDatos.Arboles
{
    abstract class Tree<T>
    {
        public T Root { get; set; }

        public Tree(T root)
        {
            this.Root = root;
        }

        public abstract bool IsLeaf();
        public abstract int DeGree();
        public abstract int Height();
    }
}
