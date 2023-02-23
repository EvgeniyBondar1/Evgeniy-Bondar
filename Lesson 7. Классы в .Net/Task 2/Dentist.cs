using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class Dentist: IPlanTreatment
    {
        public Dentist()
        {
            Console.WriteLine("Добрый день! Вам назначен дантист: Дмитрий Игоревич!");
        }
        public void Treat() 
        {
            Console.WriteLine("Дантист Вас осмотрел, вылечил и назначил план реабилитации!\n");
        }
    }
}
