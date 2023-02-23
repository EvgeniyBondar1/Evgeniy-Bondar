using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class Therapist: IPlanTreatment
    {
        public Therapist()
        {
            Console.WriteLine("Добрый день! Вам назначен терапевт: Олег Игоревич!");
        }
        public void Treat()
        {
            Console.WriteLine("Терапевт Вас осмотрел, вылечил и назначил план реабилитации!\n");
        }
    }
}
