using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11._Обобщения
{
    public class GenericArrayClass <T>
    {
        public T[] array = new T[10];

        public GenericArrayClass()
        {

        }
        /* 
         * Добавление элементов в массив
         */
        public void Add<T>(T elementArray, int count)
        {
            try
            {
                array[count] = elementArray;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        /* 
         * Получает значения из массива по индексу и возвращает число элементов
         */
        public T GetElement(int indexArray)
        {
            T valueReturnArray = array[indexArray];
            return valueReturnArray;
        }
        /* 
         * Возвращает число элементов массива
         */
        public T CountElements()
        {
            T number = array.Length;
            return number;
        }

        /* 
* Максимальное из трех прокинутых чисел
*/
        public T MaxElementIsArra<T>(T elementArray, int count)
        {
            T maxElement;
            while (count <= 3)
            {
                if (maxElement < elementArray)
                {
                    maxElement = elementArray;
                    break;
                }
            }
            return maxElement;
        }
    }
}
