﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class Alfabank: Operation
    {
        private readonly dynamic accountNumber = 5555666677778888;//номер счета
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
        public int SumResult { get; set; }

        public Alfabank(int balans) : this(balans, 0)
        {

        }

        public Alfabank(int numberOperation, int sum)
        {
            //Проблема, при вызове конструктора, переменная sumResult и invoiceAmount всегда сбрасываются и равна 0!!
            this.invoiceAmount = +sum;
            this.sumResult = sum;

            switch (numberOperation)
            {
                case 1:
                    {
                        sumResult = +sum;
                        depositMoney(sum);
                        break;
                    }
                case 2:
                    {
                        sumResult = -sum;
                        withdrawMoney(sum);
                        break;
                    }
                case 3:
                    {
                        showBalance(invoiceAmount);
                        break;
                    }

                default:
                    break;
            }
        }
        public override void depositMoney(int sum)
        {
            Console.WriteLine($"Внесены {sum} рублей!");
        }
        public override void withdrawMoney(int sum)
        {
            Console.WriteLine($"Сняты {sum} рублей!");
        }
        public override void showBalance(int invoiceAmount)
        {
            Console.WriteLine($"Баланс вашей кредитной карты: {invoiceAmount}");
        }
    }
}
