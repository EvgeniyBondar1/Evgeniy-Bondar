using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10._Обработка_исключений
{
    public class WrongPasswordException : Exception
    {
        public WrongPasswordException()
        {

        }
        public WrongPasswordException(string error) : base(error)
        {
            Console.WriteLine(error);
        }
    }
}
