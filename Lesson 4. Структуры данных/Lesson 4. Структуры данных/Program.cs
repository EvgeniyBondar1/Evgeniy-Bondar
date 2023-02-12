using System.Security.Cryptography.X509Certificates;

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

            int count = 7;
            while (count <= 98)
            {
                Console.Write(count + " ");
                Thread.Sleep(1000);

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

            #region 3. Создайте 2 массива из 5 чисел. Выведите массивы на консоль в двух отдельных строках.

            double[] array1 = new double[5] { 1, 2, 3, 4, 5 };
             double[] array2 = new double[5] { 6, 7, 8, 9, 10 };

             for (int i = 0; i < array1.Length; i++)
             {
                 Console.Write(array1[i]);
             }
             Console.WriteLine("\n");

             for (int i = 0; i < array2.Length; i++)
             {
                 Console.Write(array2[i]);
             }
             Console.WriteLine("\n");
            /*
            Вычисление среднего элемента массива
            */

            double sumElementArray1 = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                sumElementArray1 += array1[i];
            }
            var averageNumverArray1 = (sumElementArray1 / array1.Length);

            double sumElementArray2 = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                sumElementArray2 += array1[i];
            }
            var averageNumverArray2 = (sumElementArray2 / array1.Length);

            Console.WriteLine($"Среднее арифметическое значение значение массива 1: {averageNumverArray1}");
            Console.WriteLine($"Среднее арифметическое значение значение массива 2: {averageNumverArray2}");*/

            /*
            Сравнение среднего арифметического значения
            */
            if (averageNumverArray1 > averageNumverArray2)
            {
                Console.WriteLine($"Среднее арифметическое значение массива 1 больше чем у массива 2!");
            }
            else if (averageNumverArray1 < averageNumverArray2)
            {
                Console.WriteLine($"Среднее арифметическое значение массива 1 меньше чем у массива 2!");
            }
            else
            {
                Console.WriteLine($"Среднее арифметическое значение массивов равны!");
            }
            Console.ReadKey();

            #endregion

            #region Дополнительное задание
            #endregion
            #region 1. Выведите на экран первые 11 членов последовательности Фибоначчи
            Console.WriteLine("Для какого числа рассчитать последовать Фибоначчи: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Fibonacci(0, 1, 1, number);


            static void Fibonacci(int a, int b, int counter, int number) 
            {
                Console.WriteLine(a);
                if (counter < number) 
                    Fibonacci(b, a + b, counter + 1, number);
            }

            Console.ReadKey();
            #endregion

            #region 2. За каждый месяц банк начисляет 7% от суммы. Напишите программу, в которой пользователь вводит сумм вклада и количество месяцев.
            Console.WriteLine("Введите сумму вклада: ");
            decimal sum = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Введите срок вклада в месяцах: ");
            int period = Convert.ToInt32(Console.ReadLine());
            int count = 0;

            while (period > count)
            {
                sum += sum * 0.7M;
                count++;
            }
            Console.WriteLine($"После {period} месяцев сумма вклада составит {sum}");
            Console.ReadKey();
            #endregion

            #region 3. Напишите программу, выполняющие основные арифметические операции.
            //Не требуется решать,т.к. уже решали
            #endregion

            #region 4. Создайте массив из случайных целых чисел и выведите его на экран. Размер массива пусть задается с консоли....
            while (true)
            {
                Console.WriteLine("Увжаемый(ая), введите размер массива от 5 до 10: ");
                int numberMyArray = Convert.ToInt32(Console.ReadLine());

                Random random = new Random();
                int[] array01;
                int[] array02;
                int countNumber = 0;

                if (numberMyArray >= 5 && numberMyArray <= 10)
                {
                    array01 = new int[numberMyArray];

                    for (int i = 0; i < array01.Length; i++)
                    {
                        array01[i] = random.Next(1, 10);
                        Console.WriteLine($"Массив 1, с индексом {i} = {array01[i]}");
                    }
                    Console.WriteLine();

                    array02 = new int[array01.Length] ; 
                    for (int i = 0; i < array01.Length; i++)
                    {
                        if ((array01[i] % 2) == 0)
                        {
                            array02[count] = array01[i];
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine($"Массив 2, с индексом {countNumber} = {array02[countNumber]}");
                            countNumber++;
                        }
                    }
                    Console.ResetColor();
                    break;
                }
                else
                {
                    Console.WriteLine("Увжаемый(ая), вы ввели неправильный размер массива. Повторите еще разок!\n ");
                }
            }

            Console.ReadKey();

            #endregion

            #region 5. Создайте массив и заполните массив. Выведите массив на экран в строку. Замените элемент с нечетным индексом на 0.
            int[] myNewArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            for (int i = 0; i < myNewArray.Length; i++)
            {
                Console.Write(myNewArray[i]);
            }
            /*
             Замена элементов массива с нечетным индексом на 0.
             */
            Console.WriteLine("\n");
            for (int i = 0; i < myNewArray.Length; i++)
            {
                
                if ((myNewArray[i] % 2) == 1)
                {
                    myNewArray[i] = 0;
                }
                Console.Write(myNewArray[i]);
            }

            Console.ReadKey();
            #endregion

            #region 6. Создайте массив строк. Заполните его произовльными именами людей. Отсортируйте массив
            string[] arrayName = new string[] { "David", "Stiv", "Alex" };

            for (int i = 0; i < arrayName.Length; i++)
            {
                Console.WriteLine(arrayName[i]);
            }
            
            Console.WriteLine();
            Console.WriteLine("Сортировка массива: ");

            Array.Sort(arrayName);
            for (int i = 0; i < arrayName.Length; i++)
            {
                Console.WriteLine(arrayName[i]);
            }
            Console.ReadKey();

            #endregion

            #region 7. Реализуйте алгоритм сортировки пузырьком
            int[] sortArray = new int[] { 7, 8, 1, 0, 9, 3, 2, 4, 6, 5 };
            int timeCount;

            for (int i = 0; i < sortArray.Length; i++)
            {
                for (int j = 0; j < sortArray.Length - 1; j++)
                {
                    if (sortArray[j] > sortArray[j + 1])
                    {
                        timeCount = sortArray[j + 1];
                        sortArray[j + 1] = sortArray[j];
                        sortArray[j] = timeCount;
                    }
                }
            }

            for (int i = 0; i < sortArray.Length; i++)
            {
                Console.WriteLine(sortArray[i]);
            }

            Console.ReadKey();
            #endregion
        }
    }
}