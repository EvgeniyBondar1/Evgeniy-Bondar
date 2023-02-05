namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
                    break;
                case 7:
                    break;
                default:
                    Console.WriteLine("Вы ввели неверную операцию, попробуйте снова!");
                    break;
            }
            Console.ReadLine();
        }
    }
}