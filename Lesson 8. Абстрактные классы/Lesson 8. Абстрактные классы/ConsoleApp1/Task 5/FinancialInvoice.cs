using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    public class FinancialInvoice : Registr, IDocument
    {
        public decimal SumResult { get; set; }
        public DateTime DateTimeDocument { get; set; }
        public int NumberDocument { get; set; }
        public int CodeDepartament { get; set; }

        public FinancialInvoice()
        {

        }
        public FinancialInvoice(decimal sumResult, DateTime dateTimeDocument, int numberDocument, int codeDepartament)
        {
            this.SumResult = sumResult;
            this.DateTimeDocument = dateTimeDocument;
            this.NumberDocument = numberDocument;
            this.CodeDepartament = codeDepartament;
        }

        public void InformationDocument() 
        {
            Console.WriteLine($"Информация о финансовой накладной:\nИтоговая сумма за месяц: {SumResult},\nДата документа: {DateTimeDocument},\nНомер документа: {NumberDocument},\nКод департамента: {CodeDepartament}\n");
        }
        public void SaveDocumentInRegistr()
        {

        }
    }
}
