using System;


namespace Bank_Events
{
    class BankAccount
    {
        public delegate void Operation(string info);
        public event Operation AccEvent;
        public int Money { get;private set;}

        public BankAccount(int money)
        {
            Money = money;
        }

        public void BalansInfo()
        {
            Console.WriteLine($"На вашем счету {Money} рублей") ;
            
        }

        public void PutMoney(int money)
        {
            Money += money;
            Console.ForegroundColor = ConsoleColor.Green;
            AccEvent?.Invoke($"* На счет поступило {money} рублей ");
            Console.ResetColor();
            BalansInfo();
        }

        public void TakeMoney(int money)
        {
            if (Money >= money)
            {
                Money -= money;
                Console.ForegroundColor = ConsoleColor.Green;
                AccEvent?.Invoke($"* Со счета снято {money} рублей ");
                Console.ResetColor();
                BalansInfo();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                AccEvent?.Invoke("* На вашем счете недостаточно средств");
                Console.ResetColor();
                BalansInfo();
            }

        }
    }
}
