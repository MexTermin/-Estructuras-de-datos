using System;

namespace EstructurasDeDatos.Pilas
{
    public class ArrayStack<T>
    {
        protected T[] Children { get; set; } = new T[10];
        protected int Size { get; set; }
        private readonly Utils.Utils.Arrays<T> UArray;

        // O(1)
        private void ErrorIsEmpty()
        {
            if (this.IsEmpty()) throw new Exception("La pila está vacía");// 1
        }

        // O(1)
        public bool IsEmpty()
        {
            return this.Size == 0; // 1
        }

        // O(n)
        public void Push(T value)
        {
            if (this.Size == this.Children.Length) // 1
            {
                this.Children = UArray.ResizeArray(this.Children, this.Children.Length * 2, this.Size - 1); // O(n)
            }
            this.Children[this.Size] = value; // 1
            this.Size++; // 1
        }


        public T Pop()
        {
            this.ErrorIsEmpty();
            if (this.Children.Length / 2 > this.Size && this.Size > 10) // 1
            {
                this.Children = UArray.ResizeArray(this.Children, this.Size * 2, this.Size - 1); // O(n)
            }
             
            T result = this.Children[this.Size - 1];// 1
            this.Children[this.Size - 1] = default(T); // 1
            this.Size--;
            return result; // 1
        }

        // O(1)
        public T Top()
        {
            this.ErrorIsEmpty(); // 1
            return this.Children[this.Size - 1]; //1
        }
    }
}
