using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal interface IOperation
    {
        public void depositMoney(int number)
        {
            Console.WriteLine("Внести наличные:");
        }
        public void withdrawMoney(int sum)
        {
            Console.WriteLine("Снять наличные:");
        }
        public void showBalance(int number)
        {
            Console.WriteLine("Показать баланс:");
        }
    }
}
