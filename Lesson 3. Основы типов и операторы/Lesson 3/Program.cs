using System.Runtime.Intrinsics.Arm;

namespace Lesson_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1. Написать программу для вывода поры года по номеру месяца. При решении используйте оператор switch-case

            while (true)
            {
                Console.WriteLine("Введите номер месяца: ");
                int numberMonth = Convert.ToInt32(Console.ReadLine());
                switch (numberMonth)
                {
                    case 3:
                    case 4:
                    case 5:
                        Console.WriteLine("Пора года: Весна\n");
                        break;
                    case 6:
                    case 7:
                    case 8:
                        Console.WriteLine("Пора года: Лето\n");
                        break;
                    case 9:
                    case 10:
                    case 11:
                        Console.WriteLine("Пора года: Осень\n");
                        break;
                    case 12:
                    case 1:
                    case 2:
                        Console.WriteLine("Пора года: Зима\n");
                        break;
                    default:
                        Console.WriteLine("Вы ввели неправильный номер месяца!\n");
                        break;
                }
            }
            Console.ReadLine();
            #endregion

            #region 2. Написать программу для вывода поры года по номеру месяца. При решении используйте оператор if-else-if

            while (true)
            {
                Console.WriteLine("Введите номер месяца: ");
                int numberMonth = Convert.ToInt32(Console.ReadLine());
                if (numberMonth == 3 || numberMonth == 4 || numberMonth == 5)
                {
                    Console.WriteLine("Пора года: Весна\n");
                }
                else if (numberMonth == 6 || numberMonth == 7 || numberMonth == 8)
                {
                    Console.WriteLine("Пора года: Лето\n");
                }
                else if (numberMonth == 9 || numberMonth == 10 || numberMonth == 11)
                {
                    Console.WriteLine("Пора года: Осень\n");
                }
                else if (numberMonth == 12 || numberMonth == 1 || numberMonth == 2)
                {
                    Console.WriteLine("Пора года: Зима\n");
                }
                else
                {
                    Console.WriteLine("Вы ввели неправильный номер месяца!\n");
                }
            }
            Console.ReadLine();
            #endregion

            #region 3. Напишите программу, которая будет принимать на вход число и на выход быдет выводить сообщение четное число или нет.
            Console.WriteLine("___________________________________Программа определения четности числа_____________________________\n");
            while (true)
            {
                Console.WriteLine("Введите число: ");
                int number = Convert.ToInt32(Console.ReadLine());

                if ((number % 2) == 0)
                {
                    Console.WriteLine($"Введенное число {number}: четное\n");
                }
                else
                {
                    Console.WriteLine($"Введенное число {number}: нечетное\n");
                }
            }
            #endregion

            #region 4. Для введенного числа t (температура на улице) вывести температуру.
            while (true)
            {
                Console.WriteLine("Введите температуру воздуха: ");
                int temperature = Convert.ToInt32(Console.ReadLine());

                if (temperature > -5)
                {
                    Console.WriteLine("Тепло");
                }
                else if (-20 >= temperature)
                {
                    Console.WriteLine("Холодно");
                }
                else
                {
                    Console.WriteLine("Нормально, жить можно");
                }
            }
            Console.ReadLine();
            #endregion

            #region 5. По введенному номеру определить цвет радуги (1 - красный, 4 - зеленый и т.д.)

            while (true)
            {
                Console.WriteLine("Введите номер от 1 до 7, чтобы определить цвет радуги:");
                int number = Convert.ToInt32(Console.ReadLine());

                switch (number)
                {
                    case 1:
                        Console.WriteLine("1 - Цвет красный!\n");
                        break;
                    case 2:
                        Console.WriteLine("2 - Цвет оранжевый!\n");
                        break;
                    case 3:
                        Console.WriteLine("3 - Цвет желтый!\n");
                        break;
                    case 4:
                        Console.WriteLine("4 - Цвет зеленый!\n");
                        break;
                    case 5:
                        Console.WriteLine("5 - Цвет голубой!\n");
                        break;
                    case 6:
                        Console.WriteLine("6 - Цвет синий!\n");
                        break;
                    case 7:
                        Console.WriteLine("7 - Цвет фиолетовый!\n");
                        break;
                    default:
                        Console.WriteLine("Вы ввели неправильно число, попробуйте снова!\n");
                        break;
                }
            }
            #endregion

            #region 6*. Создать приложение калькулятор, выполняющий основные арифметические операции.
            Console.WriteLine("_________________________________________Приложение калькулятор___________________________________________");
            Console.WriteLine("Введите операцию:\n" +
                              "1 - Сложение\n" +
                              "2 - Вычитание\n" +
                              "3 - Деление\n" +
                              "4 - Умножение\n" +
                              "5 - Процент от числа\n" +
                              "6 - Квадратный корень числа\n" +
                              "7 - Выход\n");
            int numberOperation = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите первое число:\n");
            int numberOne = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число:\n");
            int numberTwo = Convert.ToInt32(Console.ReadLine());

            long resultOperation;

            switch (numberOperation)
            {
                case 1:
                    resultOperation = numberOne + numberTwo;
                    Console.WriteLine($"Результат сложения чисел {numberOne} и {numberTwo} равен: {resultOperation}\n");
                    break;
                case 2:
                    resultOperation = numberOne - numberTwo;
                    Console.WriteLine($"Результат вычитания чисел {numberOne} и {numberTwo} равен: {resultOperation}\n");
                    break;
                case 3:
                    // Провера деления на 0
                    if (numberTwo == 0)
                    {
                        Console.WriteLine($"Деление на {numberTwo} невозможно, попробуйте снова!\n");
                        break;
                    }
                    else
                    {
                        resultOperation = numberOne / numberTwo;
                        Console.WriteLine($"Результат деления чисел {numberOne} и {numberTwo} равен: {resultOperation}\n");
                        break;
                    }
                case 4:
                    resultOperation = numberOne * numberTwo;
                    Console.WriteLine($"Результат умножения числа {numberOne} и {numberTwo} равен: {resultOperation}\n");
                    break;
                case 5:
                    resultOperation = (numberTwo / 100) / numberOne;
                    Console.WriteLine($"Результат процента {numberOne} от числа {numberTwo} равен: {resultOperation}\n");
                    break;
                case 6:
                    int resultOperationNumberOne = (int)Math.Sqrt(numberOne);
                    int resultOperationNumberTwo = (int)Math.Sqrt(numberTwo);
                    Console.WriteLine($"Результат квадратного корня числа {numberOne} равно: {resultOperationNumberOne}\n");
                    Console.WriteLine($"Результат квадратного корня числа {numberTwo} равно: {resultOperationNumberTwo}\n");

                case 7:
                    break;
                default:
                    Console.WriteLine("Вы ввели неверную операцию, попробуйте снова!");
                    break;
            }
            #endregion
        }
    }
}