namespace Lesson_4._Структуры_данных
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1. При помощи цикла for вывести на экран нечетные числа от 1 до 99.

            for (int i = 0; i <= 99; i++)
            {
                if ((i % 2) != 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
            #endregion

            #region 2. Необходимо вывести числа от 5 до 1. Операция декремента (--)

            int number = 5;
            for (int i = 0; i < number; number--)
            {
                Console.WriteLine(number);
            }
            Console.ReadLine();
            #endregion

            #region 3. Напишите программу, где пользователь вводит любое положительное число. А программа суммирует все числа от 1 до введенного числа.

             Console.WriteLine("Введите любое положительное число: ");
             decimal positiveNumber = Convert.ToDecimal(Console.ReadLine());

             var startNumber = 1;
             var sumResult = 0;

             for (int i = 0; i < positiveNumber; i++, startNumber++)
             {
                 sumResult += startNumber;
             }
             Console.WriteLine($"Сумма чисел от 1 до {number}: {sumResult}");
             Console.ReadKey();
            #endregion

            #region 4. Необходимо, чтобы программа выводила вот такую последовательность: 7 14 21 28 35 42 49 56 63 70 77 84 91 98 

             int startNumberUser = 7;
             int count = 7;
             while (count <= 98)
             {
                 Console.Write(startNumberUser + " ");
                 Thread.Sleep(1000);

                 startNumberUser += 7;
                 count += 7;
             }
             Console.ReadKey();
            #endregion

            #region 5. Вывести 10 первых чисел последовательности 0, -5, -10, -15...

             int numberDefault = 0;
             for (int i = 0; i < 10; i++)
             {
                 Console.Write(numberDefault + ", ");
                 Thread.Sleep(1000);
                 numberDefault -= 5;
             }
             Console.ReadKey();
            #endregion

            #region 6. Составьте программу, выводящую на экран квадраты чисел от 10 до 20 включительно.

            int squareNumber = 10;
            for (int i = 10; i <= 20; i++, squareNumber++)
            {
                Console.WriteLine($"Квадрат числа {i} = {Math.BigMul(squareNumber, squareNumber)}\n");
            }
            Console.ReadKey();
            #endregion

            #region Массивы
            #endregion
            #region 0. Создайте массивых целых чисел. Напишите программу, которая выводит сообщение о том, входит ли заданное число в массив или нет.

            Console.WriteLine("Введите целое число: ");
            decimal numberUser = Convert.ToDecimal(Console.ReadLine());

            int[] array = new int[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == numberUser)
                {
                    Console.WriteLine($"Введенное число: {numberUser} входит в массив");
                }
                else
                {
                    Console.WriteLine($"Введенное число: {numberUser} не входит в массив");
                }
            }

            Console.ReadKey();

            #endregion

            #region 1. Создайте массив целых чисел. Удалите все вхождения заданного числа из массива. В результате будет новый массив без указанного числа
            Console.WriteLine("Введите целое число: ");
            decimal numberUserMy = Convert.ToDecimal(Console.ReadLine());

            int [] arrayOld = new int[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] newArray = new int [arrayOld.Length];

            for (int i = 0; i < arrayOld.Length; i++)
            {
                if (arrayOld[i] != numberUserMy)
                {
                    newArray[i] = arrayOld[i];
                    //Console.WriteLine($"Введенное число: {numberUser} входит в массив");
                }
                else
                {
                    Console.WriteLine($"Введенное число {numberUserMy}: входит в массив\n");
                }

            }
            for (int i = 0; i < newArray.Length; i++)
            {
                Console.WriteLine(newArray[i]);
            }

            Console.ReadKey();

            #endregion

            #region 2. Создайте и заполните массив случайными числами и выведите максимальное, минимально и среднее значение.

            Console.WriteLine("Введите размер нового массива: ");
            int randomNumberArray = Convert.ToInt32(Console.ReadLine());

            int[] myArray = new int [randomNumberArray];
            int maxNumberArray =  0;
            

            Random random = new Random();

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = random.Next(1, 15);
                Console.WriteLine($"Индекс массива {i} = {myArray[i]}");
            }

            /*
             Вычисление максимального элемента массива
             */

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] > maxNumberArray)
                {
                    maxNumberArray = myArray[i];
                }
            }
            
            /*
            Вычисление минимального элемента массива
            */

            int minNumberArray = myArray[0];
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] < minNumberArray)
                {
                    minNumberArray = myArray[i];
                }
            }
            
            /*
            Вычисление среднего элемента массива
            */

            var sumElementArray = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                sumElementArray += myArray[i];
            }
            var averageNumverArray = (double)(sumElementArray / myArray.Length);

            Console.WriteLine($"Максимальный элемент массива : {maxNumberArray}\n");
            Console.WriteLine($"Минимальный элемент массива : {minNumberArray}\n");
            Console.WriteLine($"Среднее значение массива : {averageNumverArray}\n");
            Console.ReadKey();
            #endregion
        }
    }
}