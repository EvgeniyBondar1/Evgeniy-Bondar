namespace Task_3
{
    internal class Program
    {
        /// <summary>
        /// Задача 3. Создать класыы - Директор, Рабочий, Бухгалтер.
        /// </summary>
        static void Main(string[] args)
        {
            Director director = new Director("Директор");
            director.NamePosition();

            Accountant accountant = new Accountant("Бухгалтер");
            accountant.NamePosition();

            Working working = new Working("Рабочий");
            working.NamePosition();

            Console.ReadKey();
        }
    }
}