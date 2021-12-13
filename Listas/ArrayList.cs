using System;
using utils = EstructurasDeDatos.Utils.Utils;

namespace EstructurasDeDatos.Listas
{
    class ArrayList : ListInterface
    {
        private int len { get; set; }
        private dynamic[] children { get; set; }
        private utils.Arrays<dynamic> uArrays { get; } = new();

        // Time Complexity: O(n)
        public void add(dynamic value)
        {
            if (this.children.Length == this.len) // 1
            {
                this.children = this.uArrays.resizeArray(this.children, this.len * 2, this.len - 1); // n
            }
            this.children[this.len] = value; // 1
            this.len++; // 1
        }

        // Time  Complexity: O(n)
        public void delete(int index)
        {
            if (index >= this.len || index < 0) // 1
            {
                throw new Exception("Índice fuera de rango"); // 1
            }
            for (var i = index; i < this.len - 1; i++) // n
            {
                this.children[i] = this.children[i + 1]; // 1
            }
            if (this.children.Length / 2 > this.len && this.len > 10) // 1
            {
                this.children = uArrays.resizeArray(this.children, this.len * 2, this.len - 1); // 1
            }
            this.len--;
        }

        // Time Complexity: O(n)
        public void insert(int index, dynamic value)
        {
            if (index >= this.len || index < 0) // 1
            {
                throw new Exception("Índice fuera de rango"); // 1
            }

            if (this.children.Length == this.len) // 1
            {
                this.children = uArrays.resizeArray(this.children, this.len * 2, this.len - 1); // 1
            }

            for (var i = this.len; i > index; i--) // n
            {
                this.children[i] = this.children[i - 1]; // 1 
            }
            this.children[index] = value; // 1
            this.len++; // 1
        }

        // Time Complexity: O(1)
        public dynamic get(int index)
        {
            if (index >= this.len || index < 0) // 1
            {
                throw new Exception("Índice fuera de rango"); // 1
            }

            return this.children[index]; // 1
        }

        //Time Complexity: O(1)
        public int lenght()
        {
            return this.len; // 1
        }

    }
}
