using System.Security.Cryptography;
using System.Collections;

namespace Lesson_5._Символы_и_строки
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 2. Дана строка произвольной длины с произвольными словами. Найти самое короткое слово в строке и вывести его на экран.
            Console.Write("Введите строку с произвольными словами: ");
            string nameString = Console.ReadLine();

            //создаем массив слов, удаляя при этом знаки пунктуации
            string[] str = nameString.Split(new Char[] { ' ', ',', '.', ':', '!', '?', ';' }, StringSplitOptions.RemoveEmptyEntries);
            int maxlen = 0, index = 0, minlen = 0, index2 = 0; 
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].Length > maxlen)
                {
                    maxlen = str[i].Length;
                    index = i;
                }
                if (str.Length < minlen)
                {
                    minlen = str[i].Length;
                    index2 = i;
                }
            }
            Console.Write("Самое длинное слово: {0}", str[index]);
            Console.WriteLine();
            Console.Write("Самое короткое слово:{0}", str[index2]);
            Console.ReadLine();

            #endregion

            #region 3. Дана строка произвольной длины с произвольными словами. Найти слово, в котором число различных символов минимально.
            string stringTaskThree = "abccc bhc3ndf aaaab erty err54rr k555";
            string[] wordsTaskThree = stringTaskThree.Split(' ');
            string firstShortestWord = wordsTaskThree[0];

            for (int i = 1; i < wordsTaskThree.Length; i++)
            {
                if (wordsTaskThree[i].Distinct().Count() > firstShortestWord.Distinct().Count()) firstShortestWord = wordsTaskThree[i];
            }

            Console.WriteLine(firstShortestWord);

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