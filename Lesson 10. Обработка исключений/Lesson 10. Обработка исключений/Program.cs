namespace Lesson_10._Обработка_исключений
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите логин:");
            string login = Console.ReadLine();

            Console.WriteLine("Введите пароль:");
            string password = Console.ReadLine();

            Console.WriteLine("Введите пподтверждающий пароль:");
            string confirmPassword = Console.ReadLine();

            MyClassError.Error(login, password, confirmPassword);
            Console.ReadKey();
        }
    }
}