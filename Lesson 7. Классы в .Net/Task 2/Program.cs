namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Задача 2. Создать программу для имитации работы клиники.
            Console.WriteLine("Вас приветствует клиника - Остаться в живых!\n" +
                "\nВыберите программу своего плана лечения:\n" +
                "1 - План лечения у хирурга:\n" +
                "2 - План лечения у дантиста:\n");

            int numberPlanTreatment = Convert.ToInt32(Console.ReadLine());
            Patient patient = new Patient(numberPlanTreatment);

            Console.WriteLine("Спасибо, что посетили нашу клинику!");
            Console.ReadKey();
            #endregion
        }
    }
}