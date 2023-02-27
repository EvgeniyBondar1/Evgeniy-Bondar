using System;

namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime();
            ContractEmployee contractEmployee = new ContractEmployee(15, DateTime.Now, DateTime.MaxValue, "Evgeniy" ); 
            contractEmployee.InformationDocument();
            contractEmployee.SaveDocumentInRegistr(contractEmployee);

            ContractGoods contractGoods = new ContractGoods(15, "Первый сорт", 10, DateTime.Now);
            contractGoods.InformationDocument();
            contractGoods.SaveDocumentInRegistr(contractGoods);

            FinancialInvoice financialInvoice = new FinancialInvoice(10000000, DateTime.Now, 103, 010);
            financialInvoice.InformationDocument();
            financialInvoice.SaveDocumentInRegistr(financialInvoice);

            Console.ReadKey();
        }
    }
}