namespace Lesson_7._Классы_в_.Net
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Задача 1. Класс Phone
            Phone phone1 = new Phone(452345, "Iphone 5", 100);
            Phone phone2 = new Phone(461540, "Iphone 6", 200);
            Phone phone3 = new Phone(478895, "Iphone 7", 300);
           
            phone1.ReceiveCall("Роберт Мартин");
            phone1.ReceiveCall("Роберт Мартин", 452345);
            phone1.SendMessage(phone1.Number);
            int getNumber1 = phone1.GetNumber(452345);
           
            phone1.Number = 452345;
            phone1.Model = "Iphone 5";
            phone1.Weight = 100;
           
            phone2.ReceiveCall("Троелсен Эндрю, Джепикс Филипп");
            phone2.ReceiveCall("Троелсен Эндрю, Джепикс Филипп", 461540);
            phone2.SendMessage(phone2.Number);
            int getNumber2 = phone2.GetNumber(461540);
            
            phone2.Number = 461540;
            phone2.Model = "Iphone 6";
            phone2.Weight = 200;

            phone3.ReceiveCall("Рихтер Джеффри");
            phone3.ReceiveCall("Рихтер Джеффри", 478895);
            phone3.SendMessage(phone3.Number);
            int getNumber3 = phone3.GetNumber(478895);
            
            phone3.Number = 478895;
            phone3.Model = "Iphone 7";
            phone3.Weight = 300;

            Console.WriteLine($"Вывод номера телефона: {getNumber1}");
            Console.WriteLine($"Вывод номера телефона: {getNumber2}");
            Console.WriteLine($"Вывод номера телефона: {getNumber3}\n");
            Console.WriteLine($"Номер: {phone1.Number}, модель: {phone1.Model}, вес: {phone1.Weight}");
            Console.WriteLine($"Номер: {phone2.Number}, модель: {phone2.Model}, вес: {phone2.Weight}");
            Console.WriteLine($"Номер: {phone3.Number}, модель: {phone3.Model}, вес: {phone3.Weight}");

            Console.ReadKey();
            #endregion
        }
    }
}