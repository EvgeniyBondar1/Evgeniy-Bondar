using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal interface IPlanTreatment
    {
        public void Treat() 
        {
            Console.WriteLine("Лечить!");
        
        }
    }
}
