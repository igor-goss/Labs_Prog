using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Prog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program that check if digits of number are egual");
            while(true)
            {
                Console.WriteLine("Chose option\n1.Continue\n2.Exit");
                int option;
                int.TryParse(Console.ReadLine(), out option);
                switch(option)
                {
                    case 1:
                        Console.WriteLine("Enter 2-digit number");
                        var numberAsString = Console.ReadLine();
                        int number;
                        if (int.TryParse(numberAsString, out number))
                        {
                            if (number < 10 || number > 99)
                                Console.WriteLine("Incorrect input. Enter 2-digit number");
                            else
                            {
                                if (number % 10 == number / 10)
                                    Console.WriteLine("Digits of this number are equal");
                                else
                                    Console.WriteLine("Digits of this number aren't equal");
                            }
                        }
                        else
                            Console.WriteLine("Incorrect input. Enter 2-digit number");
                        break;
                    case 2:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Incorrect option. Try again");
                        break;
                }
            }
        }
    }
}
