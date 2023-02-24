namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var intro = new IntroStruct();
            var transaction = new AccountTransact();

            int opt;

            intro.Intro();
            intro.Loading();
            Console.Clear();

            do
            {
                Console.Write("\n\tОсновное меню:");
                Console.Write("\n 1. Создать новый Аккаунт");
                Console.Write("\n 2. Информация об Аккаунте");
                Console.Write("\n 3. Обновить информацию об Аккаунте");
                Console.Write("\n 4. Внесите деньги на депозит:");
                Console.Write("\n 5. Снять деньги с депозита:");
                Console.Write("\n 6. Показать баланс:");
                Console.Write("\n 7. Выход из приложения");
                Console.Write("\n Выберите опцию от 1 до 7:");
                opt = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opt)
                {
                    case(int)Options.New:
                        {
                            Console.Clear();
                            intro.Loading();
                            Console.Clear();
                            transaction.CreateAccount();
                            break;
                        }
                    case (int)Options.Exit:
                        {
                            Environment.Exit(0);//закрыть приложение полностью
                            break;
                        }
                    case (int)Options.Show:
                        {
                            Console.Clear();
                            intro.Loading();
                            Console.Clear();
                            transaction.ShowAccount();
                            break;
                        }
                    case (int)Options.Deposit:
                        {
                            Console.Clear();
                            intro.Loading();
                            Console.Clear();
                            transaction.MoneyDeposit();
                            break;
                        }
                    case (int)Options.WithDraw:
                        {
                            Console.Clear();
                            intro.Loading();
                            Console.Clear();
                            transaction.MoneyWithdraw();
                            break;
                        }
                    case (int)Options.BalanseShow:
                        {
                            Console.Clear();
                            intro.Loading();
                            Console.Clear();
                            transaction.BalansShow();
                            break;
                        }
                    case (int)Options.Modify:
                        {
                            Console.Clear();
                            intro.Loading();
                            Console.Clear();
                            Console.Write("Введите Id Аккаунта:");
                            int id = int.Parse(Console.ReadLine());
                            transaction.ModifyAccount(id);
                            break;
                        }

                    default:
                        break;
                }

            } while (opt != (int)Options.Exit);

        }
    }
}