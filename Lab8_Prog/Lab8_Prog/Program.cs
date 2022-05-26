using System;

namespace Lab8_Prog
{
    public class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            bank.SetStrategy(new AddDepositWOAdditional());
            bank.SetStrategy(new AddDepositWAdditional());
        }
    }
}