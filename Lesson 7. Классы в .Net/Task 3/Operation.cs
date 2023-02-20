using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class Operation
    {
        public virtual void depositMoney(int number)
        {
            Console.WriteLine("Внести наличные:");
        }
        public virtual void withdrawMoney(int sum)
        {
            Console.WriteLine("Снять наличные:");
        }
        public virtual void showBalance(int number)
        {
            Console.WriteLine("Показать баланс:");
        }

      

    }
}
