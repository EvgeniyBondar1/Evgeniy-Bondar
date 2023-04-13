using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10._Обработка_исключений
{
    public class MyClassError
    {
        public static void Error(string login, string password, string confirmPassword)
        {
            try
            {
                for (int i = 0; i < login.Length; i++)
                {
                    //TODO: оптимизировать
                    char probel = ' ';
                    if (login[i] == probel || (login.Length > 20))
                    {
                        throw new WrongLoginException();
                    }
                }
            }
            catch (WrongLoginException ex1)
            {
                WrongLoginException wrongLoginException = new WrongLoginException("WrongLoginException");
            }

            try
            {
                /** 
                 * Проверка password на наличие цифр (0-9)
                 */ 
                 var isCheckNumber = false;
                 char probel = ' ';

                foreach (char c in password)
                    {
                        if (c < '0' || c > '9')
                        {
                           isCheckNumber =  true;
                        }   
                    }
                /** 
                * Проверка password на наличие цифр (0-9)
                * - длина password меньше 20
                * - не содержит пробелы
                * - должна содержать одну цифру
                * - password и confirmPassword
                */
                for (int i = 0; i < password.Length; i++)
                {
                    if (password[i] == probel || password.Length > 20 || password != confirmPassword || !isCheckNumber)
                    {
                        throw new WrongPasswordException();
                    }
                }
            }
            catch (WrongPasswordException ex2)
            {
                WrongPasswordException wrongPasswordException = new WrongPasswordException("WrongPasswordException");
            }
        }
    }
}
