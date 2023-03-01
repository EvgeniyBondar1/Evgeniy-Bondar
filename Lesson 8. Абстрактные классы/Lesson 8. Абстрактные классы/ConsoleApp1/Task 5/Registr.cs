using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    public class Registr
    {
        private int Number { get; set; }
       
        public Object[] documents = new Object[10];

        public void SaveDocumentInRegistr(Object newDoc) 
        {
            documents[Number] = newDoc;
            Number++;
        }
    }
}
