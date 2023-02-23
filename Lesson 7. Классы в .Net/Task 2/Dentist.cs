using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class Dentist: PlanTreatment
    {
        public Dentist()
        {
            Console.WriteLine("Добрый день! Вам назначен дантист: Дмитрий Игоревич!");
        }
        public override void Treat() 
        {
            Console.WriteLine("Дантист Вас осмотрел, вылечил и назначил план реабилитации!\n");
        }
    }
}
