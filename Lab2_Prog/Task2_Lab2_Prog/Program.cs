using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_Lab2_Prog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter coordinates:");
            var xAsString = Console.ReadLine();
            double x;
            double.TryParse(xAsString, out x);
            string yAsString = Console.ReadLine();
            double y;
            double.TryParse(yAsString, out y);
            if (x * x + y * y < 625 && y < -x)
                Console.WriteLine("Yes");
            else
            {
                if (x * x + y * y == 625 || y == -x)
                    Console.WriteLine("On the border");
                else
                    Console.WriteLine("No");
            }
            Console.ReadLine();
        }
    }
}
