﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class Surgeon: IPlanTreatment
    {
        public Surgeon()
        {
            Console.WriteLine("Добрый день! Вам назначен хирург: Евгений Игоревич!");
        }
        public void Treat()
        {
            Console.WriteLine("Хирург Вас осмотрел, вылечил и назначил план реабилитации!\n");
        }
    }
}
