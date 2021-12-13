using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasDeDatos.Listas
{
    interface ListInterface
    {
        public void add(dynamic value);
        public void delete(int index);
        public void insert(int index, dynamic value);
        public dynamic get(int index);
        public int lenght();
    }
}
