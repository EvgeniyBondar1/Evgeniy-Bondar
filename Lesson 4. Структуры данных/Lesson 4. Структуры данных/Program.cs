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

            for (int i = 0; i < number; i++, startNumber++)
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
        }
    }
}