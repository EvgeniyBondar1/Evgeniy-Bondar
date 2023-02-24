namespace ConsoleApp1
{
    internal class Program
    {

        /// <summary>
        /// Задача 1. Вывод списка дней недели через перечисление в C#.
        /// </summary>
        enum DaysWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sanday
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine(DaysWeek.Monday);
            Console.WriteLine(DaysWeek.Tuesday);
            Console.WriteLine(DaysWeek.Wednesday);
            Console.WriteLine(DaysWeek.Thursday);
            Console.WriteLine(DaysWeek.Friday);
            Console.WriteLine(DaysWeek.Saturday);
            Console.WriteLine(DaysWeek.Sanday);

            Console.ReadKey();
        }
    }
}