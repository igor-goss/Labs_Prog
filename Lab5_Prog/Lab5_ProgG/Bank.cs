using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_ProgG
{
    internal class Bank
    {
        static public int NumOfClients = 25;
        public static int numOfClients
        {
            get { return NumOfClients; }
            set { NumOfClients = value; }
        }

        Client[] clients = new Client[NumOfClients];

        public void Setup()
        {
            for (int i = 0; i < NumOfClients; i++)
            {
                clients[i] = new Client();
                clients[i].setup();
            }
        }

        public void ShowListOfClients()
        {
            int i = 1;
            foreach (Client client in clients)
            {
                Console.WriteLine($"{i}.{client.name}");
                i++;
            }
        }

        public void ShowClientInfo(int num)
        {
            Console.WriteLine($"Name: {clients[num - 1].name}");
            Console.WriteLine($"Number of deposits: {clients[num - 1].numOfDeposits}");
        }

        public void ChangeClientInfo(int num, string name, int numOfDeposits)
        {
            clients[num - 1].name = name;
            clients[num - 1].numOfDeposits = numOfDeposits;
        }


        public double CalculateRevenueForAClient(int num, int period)
        {
            double revenue = 0;
            Client client = clients[num - 1];
            for (int i = 0; i < client.numOfDeposits; i++)
            {
                revenue += client.deposits[i].CalcRevenue(period);
            }
            return revenue;
        }

        public double CalculateGeneralRevenue(int period)
        {
            double generalRevenue = 0;
            for (int i = 0; i < NumOfClients; i++)
            {
                generalRevenue += CalculateRevenueForAClient(i, period);
            }
            return generalRevenue;
        }
    }
}
