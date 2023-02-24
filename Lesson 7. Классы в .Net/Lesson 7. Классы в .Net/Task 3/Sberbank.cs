using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class Sberbank: IOperation
    {
        private readonly dynamic accountNumber = 9999888877776666;//номер счета
        private int invoiceAmount; //текущая сумма на счету 
        public int numberOperation;
        private int sumResult;
        public dynamic AccountNumber { get; set; }
        public int InvoiceAmount
        {
            get
            {
                return invoiceAmount;
            }
            set
            {
                invoiceAmount = value;
            }
        }
        public int NumberOperation
        {
            get
            {
                return numberOperation;
            }

            set
            {
                numberOperation = value;
            }
        }

        public Sberbank(int balans) : this(balans, 0)
        {

        }
        public Sberbank(int numberOperation, int sum)
        {

            //Проблема, при вызове конструктора, переменная sumResult и invoiceAmount всегда сбрасывается и равна 0!!
            this.invoiceAmount = +sum;
            this.sumResult = sum;

            switch (numberOperation)
            {
                case 1:
                    {
                        sumResult = +sum;
                        depositMoney(sumResult);
                        break;
                    }
                case 2:
                    {
                        sumResult = +sum;
                        withdrawMoney(sum);
                        break;
                    }
                case 3:
                    {
                        sumResult = +sum;
                        showBalance(sumResult);
                        break;
                    }

                default:
                    break;
            }
        }
        public void depositMoney(int sum)
        {
            Console.WriteLine($"Внесены {sum} рублей!");
        }
        public void withdrawMoney(int sum)
        {
            Console.WriteLine($"Сняты {sum} рублей!");
        }
        public void showBalance(int invoiceAmount)
        {
            Console.WriteLine($"Баланс вашей кредитной карты: {invoiceAmount}");
        }
    }

}
