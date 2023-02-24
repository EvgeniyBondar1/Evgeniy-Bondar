using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class CreditCard
    {
        public CreditCard(int numberCreditCard, int numberOperation, int sum)
        {
            switch (numberCreditCard)
            {
                case 1:
                    {
                       Gazprombank gazprombank = new Gazprombank(numberOperation, sum);
                       break;
                    }
                case 2:
                    {
                        Sberbank sberbank = new Sberbank(numberOperation, sum);
                        break;
                    }
                case 3:
                    {
                        Alfabank alfabank = new Alfabank(numberOperation, sum);
                        break;
                    }
                default:
                    break;
            }
        }

        public CreditCard(int balans, int summa)
        {
            switch (balans)
            {
                case 1:
                    {
                        Gazprombank gazprombank = new Gazprombank(balans = 3);
                        break;
                    }
                case 2:
                    {
                        Sberbank Sberbank = new Sberbank(balans = 3);
                        break;
                    }
                case 3:
                    {
                        Gazprombank gazprombank = new Gazprombank(balans = 3);
                        break;
                    }

                default:
                    break;
            }
        }
    }
}
