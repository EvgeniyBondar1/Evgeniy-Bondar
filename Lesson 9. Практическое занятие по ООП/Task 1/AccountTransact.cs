using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class AccountTransact: AccountInfo, Itranzaction
    {
        public void CreateAccount()
        {
            Console.Write("-----Введите информацию об аккаунте:------- \n");
            Console.Write("Введите Аккаунт Id: \n");
            AccountId = int.Parse(Console.ReadLine());

            Console.Write("Введите имя Аккаунта: \n");
            AccountName = Console.ReadLine();

            Console.Write("_____Введите тип Аккакунта (Коммерческий - С/Персональный - P):\n");
            AccountType = Convert.ToChar(Console.ReadLine());

            Console.Write("_____Введите депозит:______ \n");
            Deposit = decimal.Parse(Console.ReadLine());
        }
        public void ShowAccount()
        {
            Console.WriteLine("-----Информация об аккаунте:-------");
            Console.WriteLine($"Аккаунт Id - {AccountId} ");
            Console.WriteLine($"Имя Аккаунта - {AccountName}");
            Console.WriteLine($"Тип Аккаунта - {AccountType}");
            Console.WriteLine($"Депозит - {Deposit}");
            Console.WriteLine($"Время создания аккаунта - {OpenedDate.ToString("dd-MM-yyyy HH:mm")}");
            Console.WriteLine("------------------------------------");
        }
        public void ModifyAccount(int accountId)
        {
            if (accountId == AccountId)
            {
                Console.Write("-----Обновление Аккаунта------- \n");
                Console.WriteLine($"Текущий Аккаунтй Id {AccountId}");
                Console.WriteLine($"Обновите имя Аккаунта: ");

                AccountName = Console.ReadLine();
            }
            else
            {
                Console.Write("Неверный Id Аккаунта!");
            }
        }
        public void MoneyDeposit()
        {
            decimal amount;
            Console.WriteLine("Сколько ты хочешь внести денег:");
            amount = decimal.Parse(Console.ReadLine());
            if (amount >= 0) Deposit += amount;
            else Console.WriteLine("Введите положительую сумму");
        }
        public void MoneyWithdraw()
        {
            decimal amount;
            Console.WriteLine("Сколько ты хочешь снять денег:");
            amount = decimal.Parse(Console.ReadLine());
            if (amount >= 0) Deposit -= amount;
            else Console.WriteLine("Введите положительую сумму");
        }
        public void BalansShow()
        {
            Console.WriteLine("-----Информация о иекущем балансе:-------");
            Console.WriteLine($"Баланс - {Deposit} ");
        }
    }
}
