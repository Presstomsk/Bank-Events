using System;

namespace Bank_Events
{
    class Program
    {
        static void Main()
        {
            BankAccount account = new BankAccount(1000);
            account.BalansInfo();
            account.AccEvent += Info;
            account.PutMoney(500);            
            account.TakeMoney(300);           
            account.TakeMoney(1500);
            
        }
        public static void Info(string info)
        {         
            Console.WriteLine(info);            
        }
    
    }
}
