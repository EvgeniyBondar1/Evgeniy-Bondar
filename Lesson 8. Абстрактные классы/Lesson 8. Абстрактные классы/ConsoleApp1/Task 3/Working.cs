using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Working: INamePosition
    {
        private string namePos;

        public string NamePos
        {
            get { return namePos; }
            set { namePos = value; }
        }
        public Working()
        {

        }
        public Working(string name)
        {
            this.namePos = name;
        }
        public void NamePosition()
        {
            Console.WriteLine($"Текущая должность: {namePos}");
        }
    }
}
