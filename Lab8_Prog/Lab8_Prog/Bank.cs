using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_Prog
{
    internal class Bank
    {
        public List<Client> clients;
        public int numOfClients = 0;
        private IStrategy _strategy;

        public Bank()
        {

        }

        public Bank(IStrategy strategy)
        {
            this._strategy = strategy;
        }

        public void SetStrategy(IStrategy strategy)
        {
            this._strategy = strategy;
        }

        public void AddNewDeposit(float ammount)
        {
            clients.Append<Client>(new Client());
            numOfClients++;
            clients[numOfClients].depositAmmount = ammount;
        }
    }

    public interface IStrategy
    {
        void AddNewDeposit(float ammount);
    }

    class AddDepositWOAdditional : IStrategy
    {
        public void AddNewDeposit(float ammount)
        {
            Bank bank = new Bank();
            bank.clients.Append<Client>(new Client());
            bank.numOfClients++;
            bank.clients[bank.numOfClients].depositAmmount = ammount;
        }
    }

    class AddDepositWAdditional : IStrategy
    {
        public void AddNewDeposit(float ammount)
        {
            Bank bank = new Bank();
            bank.clients.Append<Client>(new Client());
            bank.numOfClients++;
            bank.clients[bank.numOfClients].depositAmmount = ammount + 1000;
        }
    }

    
}
