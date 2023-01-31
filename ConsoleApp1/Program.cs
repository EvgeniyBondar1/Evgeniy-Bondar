namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Вы ввели число: {number}");
            Console.ReadLine();
        }
    }
}