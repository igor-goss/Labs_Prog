using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Prog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option;

            while (true)
            {
                Console.WriteLine("Chose optino:");
                Console.WriteLine("1.Show the list of clients");
                Console.WriteLine("2.Show information about client");
                Console.WriteLine("3.Change client information");
                Console.WriteLine("4.Calculate revenue for a client");
                Console.WriteLine("5.Calculate general revenue");
                Console.WriteLine("5.Exit program");
                int.TryParse(Console.ReadLine(), out option);

                switch (option)
                {
                    case 1:

                        break;

                    case 2:

                        break;

                    case 3:

                        break;

                    case 4:

                        break;

                    case 5:
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
