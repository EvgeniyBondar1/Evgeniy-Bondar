namespace Task_2
{

    /// <summary>
    /// Задача 2. Создать структуру UserInfo, Которая включает в себя Name Age Address Surname Login Password. Вывести поля структуры в консоль
    /// </summary>
    struct UserInfo
    {
        private string name;
        private int age;
        private string adress;
        private string surname;
        private string login;
        private string password;

        public UserInfo(string name,string password)
        {
            this.name = name;
            this.password = password;
            this.age = 33;
            this.adress = "Sankt-Petersburg";
            this.surname = "Bondar";
            this.login = "1244";
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Adress
        {
            get { return adress; }
            set { adress = value; }
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public string Login
        {
            get { return login; }
            set { login = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            UserInfo userInfo = new UserInfo("Evgeniy", "55");
            userInfo.Age = 33;

            Console.WriteLine($"Name: {userInfo.Name}");
            Console.WriteLine($"Age: {userInfo.Age}");
            Console.WriteLine($"Adress: {userInfo.Adress}");
            Console.WriteLine($"Surname: {userInfo.Surname}");
            Console.WriteLine($"Login: {userInfo.Login}");
            Console.WriteLine($"Password: {userInfo.Password}");

            Console.ReadKey();
        }
    }
            

    
}