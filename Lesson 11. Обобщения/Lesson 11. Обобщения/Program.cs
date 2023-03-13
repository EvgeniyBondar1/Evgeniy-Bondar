using System;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;

namespace Lesson_11._Обобщения
{
    public class GenericArrayClass<T>
    {
        public T[] array = new T [10];
        
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
        public T MaxElementIsArra<T>(T elementArray,int count) 
        {
            int maxElement = 0;
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
    public class Program
    {
        static void Main(string[] args)
        {
            GenericArrayClass genericArrayClass = new GenericArrayClass();
            int maxElement = 0;
            int count = 0;
            while (count <= 10)
            {
                Console.WriteLine($"Введите {count} элемент массива:"); 
                int elementArray = Convert.ToInt32(Console.ReadLine());
                genericArrayClass.Add(elementArray, count);
                maxElement = genericArrayClass.MaxElementIsArra(elementArray, count);
                count++;
            }

            Console.WriteLine("Введите индекс массива: ");

            var indexArray = Convert.ToInt32(Console.ReadLine());
            var valueReturnArray = genericArrayClass.GetElement(indexArray);
            Console.WriteLine($"Значение массива по индексу {indexArray}: {valueReturnArray} ");

            var countElements = genericArrayClass.CountElements();
            Console.WriteLine($"Количество элементов в массиве: {countElements}");

            #region Создайте Generic метод, который будет возвращать максимальное из трех прокинутых чисел в параметрах
            Console.WriteLine($"Максимальное из трех прокинутых чисел в параметрах: {maxElement}");
            #endregion
            Console.ReadKey();
        }
    }
}