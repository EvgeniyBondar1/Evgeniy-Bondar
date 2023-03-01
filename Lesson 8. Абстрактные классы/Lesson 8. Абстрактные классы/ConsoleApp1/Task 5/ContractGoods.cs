using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    public class ContractGoods : Registr, IDocument
    {
        public int NumberDocument { get; set; }
        public string ProductType { get; set; }
        public int Product { get; set; }
        public DateTime DateTime { get; set; }

        public ContractGoods()
        {

        }
        public ContractGoods(int numberDocument, string productType, int product, DateTime dateTime)
        {
            this.NumberDocument = numberDocument;
            this.ProductType = productType;
            this.Product = product;
            this.DateTime = dateTime;
        }
        public void InformationDocument() 
        {
            Console.WriteLine($"Информация о контракте на поставку товаров:\nНомер документа: {NumberDocument},\nТип товара: {ProductType},\nКоличество товаров: {Product},\nДата документа: {DateTime}\n");
        }
        public void SaveDocumentInRegistr()
        {

        }

    }
}
