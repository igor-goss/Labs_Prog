using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_ProgG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            bank.Setup();
            Client client = new Client();

            int option;

            while (true)
            {
                Console.WriteLine("Chose option:");
                Console.WriteLine("1.Show the list of clients");
                Console.WriteLine("2.Show information about client");
                Console.WriteLine("3.Change client information");
                Console.WriteLine("4.Calculate revenue for a client");
                Console.WriteLine("5.Calculate general revenue");
                Console.WriteLine("6.Exit program\n");
                int.TryParse(Console.ReadLine(), out option);

                switch (option)
                {
                    case 1:
                        bank.ShowListOfClients();
                        break;

                    case 2:
                        int num1;
                        Console.WriteLine("Enter client number:");
                        int.TryParse(Console.ReadLine(), out num1);
                        bank.ShowClientInfo(num1);
                        break;

                    case 3:
                        Console.WriteLine("Enter client  number:");
                        int num;
                        int.TryParse(Console.ReadLine(), out num);
                        Console.WriteLine("Enter new name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter new number of deposits:");
                        int numOfDeposits;
                        int.TryParse(Console.ReadLine(), out numOfDeposits);
                        bank.ChangeClientInfo(num, name, numOfDeposits);
                        break;

                    case 4:
                        Console.WriteLine("Enter client number:");
                        int.TryParse(Console.ReadLine(), out num);
                        Console.WriteLine("Enter time period in months:");
                        int period;
                        int.TryParse(Console.ReadLine(), out period);
                        Console.WriteLine($"Reevenue for this client: {bank.CalculateRevenueForAClient(num, period)}");
                        break;

                    case 5:
                        Console.WriteLine("Enter time period in months:");
                        int.TryParse(Console.ReadLine(), out period);
                        Console.WriteLine($"General revenue: {bank.CalculateGeneralRevenue(period)}");
                        break;

                    case 6:
                        Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("incorrect input. Try again");
                        break;

                }
            }
        }
    }

}