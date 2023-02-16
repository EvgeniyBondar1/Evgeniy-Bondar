namespace Lesson_6._Введение_в_ООП
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Phone phone1 = new Phone(461540, "Iphone", "5c");
            
            Console.WriteLine($"number: {phone1.Number}, model: {phone1.Model}, weight: {phone1.Weight}");
            phone1.receiveCall("Jeffrey Richter");
            string result1 = phone1.getNumber(phone1.Model);
            Console.WriteLine(result1);

            Console.WriteLine(new string('-', 30));

            Phone phone2 = new Phone(451234, "Samsung");
            phone2.receiveCall("Steve McConnell");
            Console.WriteLine($"number: {phone2.Number}, model: {phone2.Model}, weight: {phone2.Weight}");

            Console.WriteLine(new string('-', 30));

            Phone phone3 = new Phone();
            phone3.receiveCall("CLR via C#");

            Console.ReadKey();
 
        }
    }
}