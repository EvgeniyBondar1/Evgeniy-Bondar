using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    struct IntroStruct
    {
        public void Intro()
        {
            Console.WriteLine("Добро пожаловать в мой Банк!");
        }
        public void Loading()
        {
            Console.WriteLine("Загрузка.....");
            for (int i = 0; i < 5; i++)
            {
                Console.Write('#');
                Thread.Sleep(500);
            }
        }



    }
}
