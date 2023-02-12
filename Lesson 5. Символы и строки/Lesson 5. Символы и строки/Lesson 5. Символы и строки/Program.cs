using System.Security.Cryptography;

namespace Lesson_5._Символы_и_строки
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 2. Дана строка произвольной длины с произвольными словами. Найти самое короткое слово в строке и вывести его на экран.

            #endregion

            #region 3. Дана строка произвольной длины с произвольными словами. Найти слово, в котором число различных символов минимально.

            #endregion

            #region 4. Дана строка произвольной длины с произвольными словами. Найти слово, в котором число различных символов минимально.

            #endregion

            #region 5. Дана произвольная строка. Вывести на консоль новую строку, в которой задублирована каждая буква из начальной строки.
            String s2 = new string('-', 110);
            Console.WriteLine(s2);
            
            string oldName = "Hello!!";
            Console.WriteLine($"Старое имя: \n{oldName}");
            char [] newName = new char[oldName.Length * 2];
            int count = 0;

            for (int i = 0; i < oldName.Length; i++, count++)
            {
                newName[count] = oldName[i];
                count++;
                newName[count] = oldName[i];
            }

            Console.WriteLine("\nНовое имя");
            for (int i = 0; i < newName.Length; i++)
            {
                Console.Write(newName[i]);
            }

            Console.ReadKey();

            #endregion

        }
    }
}