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
                    string name = "";
                    //TODO: доделать условие
                    bool flag = login[0] == (string)name ? true : false;
                }
                if ((login.Length < 20) && !string.IsNullOrWhiteSpace(login))
                {

                    throw new WrongLoginException();
                }
            }
            catch (WrongLoginException ex1)
            {
                WrongLoginException wrongLoginException = new WrongLoginException("WrongLoginException");
            }

            try
            {

                //TODO: доделать условие
                if (password.Length < 20 && (password == confirmPassword))
                {
                    throw new WrongPasswordException();
                }
            }
            catch (WrongPasswordException ex2)
            {
                WrongPasswordException wrongPasswordException = new WrongPasswordException("WrongPasswordException");
            }
        }
    }
}
