
namespace EstructurasDeDatos.Utils
{
    class Utils
    {
        public class Arrays<T>
        {
            // Time Complexity: O(n)
            public T[] ResizeArray(T[] oldArray, int size, int endFill)
            {
                T[] newArray = new T[size]; // 1

                for (var index = 0; index <= endFill; index++)
                {          // n
                    newArray[index] = oldArray[index]; // 1
                }
                return newArray; // 1
            }
        }
    }
}
