using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7._Классы_в_.Net
{
    class Phone
    {
        //Поля
        private int number;
        private string model;
        private int weight;
        private string name;

        //Свойства
        public int Number
        {
            get { return number; }
            set { number = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //Конструктор по умолчанию
        public Phone()
        {

        }

        //Пользовательский конструктор
        public Phone(int number, string model, int weight)
            : this(355345, "Panasonic")
        {
            this.number = number;
            this.model = model;
            this.weight = weight;
        }
        public Phone(int number, string model)
        {
            this.number = number;
            this.model = model;
        }

        //Перегрузка методов
        public void receiveCall(string name)
        {
            Console.WriteLine($"Звонит: {name}!");
        }
        public void receiveCall(string name, int number)
        {
            Console.WriteLine($"Звонит: {name}, номер телефона: {number}");
        }
        //Возврат номера телефона
        public int getNumber(int number)
        {
           return number;
        }

        //Отправка сообщений
        public void sendMessage(int number)
        {
            switch (number)
            {
                case 452345:
                    {
                        processingSendMessage(452345);
                        break;
                    }
                case 461540:
                    {
                        processingSendMessage(461540);
                        break;
                    }
                case 478895:
                    {
                        processingSendMessage(478895);
                        break;
                    }
                default:
                    break;
            }
        }

        //Обработка отправки сообщений (инкапсуляция)
        private void processingSendMessage(int number)
        {
            Console.WriteLine($"На номер: {number}, будет отправлено сообщение!\n");
        }
    }
}
