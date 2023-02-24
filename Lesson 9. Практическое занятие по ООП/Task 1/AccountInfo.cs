using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class AccountInfo
    {
        private int accountId;
        private string accountName;
        private decimal deposit;
        private char accountType;
        private DateTime openedDate;

        public AccountInfo()
        {
            openedDate = DateTime.Now;
        }

        public int AccountId
        {
            get { return accountId; }
            set { accountId = value; }
        }
        public string AccountName
        {
            get { return accountName; }
            set { accountName = value; }
        }
        public char AccountType
        {
            get { return accountType; }
            set { accountType = value; }
        }
        public decimal Deposit
        {
            get { return deposit; }
            set
            {
                if (value >= 0)
                {
                    deposit = value;
                }
                else
                {
                    Console.WriteLine("Депозит не может быть меньше 0!");
                }
            }
        }
        public DateTime OpenedDate
        {
            get { return openedDate; }
        }

    }
}
