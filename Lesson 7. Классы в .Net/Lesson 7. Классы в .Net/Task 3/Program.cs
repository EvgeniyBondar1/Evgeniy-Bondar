namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Link1:
            Console.WriteLine("Выберите кредитную карту:\n" +
                "1 - Газпромбанк:\n" +
                "2 - Сбербанк:\n" +
                "3 - Альфа-банк:\n");
            int numberCreditCard = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(
                "Введите операцию:\n" +
                "1 - Внести наличные на кредитную карту:\n" +
                "2 - Снять наличные с кредитной карты:\n" +
                "3 - Показать баланс кредитной карты:\n" +
                "4 - Показать баланс всех карт:");

            int numberOperation = Convert.ToInt32(Console.ReadLine());
            int summa = 0;
            int balans = 0;

            switch (numberOperation)
            {
                case 1:
                case 2:
                    {
                        Console.WriteLine("Введите сумму:");
                        summa = Convert.ToInt32(Console.ReadLine());
                        CreditCard creditCard1 = new CreditCard(numberCreditCard, numberOperation, summa);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Баланс какой карты показать:");
                        Console.WriteLine("Введите операцию:\n" +
                                          "1 - Газпромбанк:\n" +
                                          "2 - Сбербанк:\n" +
                                          "3 - Альфабанк:\n");
                        balans = Convert.ToInt32(Console.ReadLine());
                        CreditCard creditCard = new CreditCard(balans, summa);
                        break;
                    }
                default:
                    Console.WriteLine("Нет такой карты, повторите заново!");
                    break;
            }

            goto Link1;
            Console.ReadKey();
        }
    }
}