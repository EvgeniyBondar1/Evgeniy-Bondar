using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Schema;

namespace Lesson_6._Введение_в_ООП
{
    public class Phone
    {
        // Поля
        private dynamic number;
        private string model;
        private string weight;

        // Свойства
        public dynamic Number
        {
            get { return number; }
            set { number = value; }
        }
        public string Model 
        {
            get { return model; }
            set { model = value; }
        }
        public string Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        //Конструкторы
        public Phone(dynamic number, string model, string weight)
        {
            Console.WriteLine("Пользовательский конструктор c 3-мя параметрами!");
            this.number = number;
            this.model = model;
            this.weight = weight;
        }
        public Phone(dynamic number, string model)
        {
            Console.WriteLine("Пользовательский конструктор с 2-мя параметрами!");
            this.number = number;
        }
        public Phone()
        {
            Console.WriteLine("Конструктор по умолчанию!");
        }
       
        public void receiveCall(string nameCall) 
        {
            Console.WriteLine($"Звонит: {nameCall}");
        }
       
        public string getNumber(string number)
        {
            return number;
        }
     }
}
