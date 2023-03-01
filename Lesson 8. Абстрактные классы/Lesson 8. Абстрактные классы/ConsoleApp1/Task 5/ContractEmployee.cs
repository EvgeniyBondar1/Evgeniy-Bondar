using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    public class ContractEmployee : Registr, IDocument
    {
        public int NumberDocument { get; set; }
        public DateTime DateTime { get; set; }
        public DateTime DateTimeFinischContract { get; set; }
        public string NameEmployee { get; set; }

        public ContractEmployee()
        {

        }
        public ContractEmployee(int numberDocument, DateTime dateTime, DateTime dateTimeFinischContract, string nameEmployee)
        {
            this.NumberDocument = numberDocument;
            this.DateTime = dateTime;
            this.DateTimeFinischContract = dateTimeFinischContract;
            this.NameEmployee = nameEmployee;
        }

        public void InformationDocument() 
        {
            Console.WriteLine($"Информация о контракте с сотрудником:\nНомер документа: {NumberDocument},\nДата документа: {DateTime},\nДата окончания контракта: {DateTimeFinischContract},\nИмя сотрудника: {NameEmployee}\n");
        }
        public void SaveDocumentInRegistr()
        { 
        
        }
    }
}
