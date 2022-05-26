using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_Lab3_Prog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var f = new Task2_Lab3_Prog.Services.Class1();
            Console.WriteLine("Enter four numbers");
            double n = double.Parse(Console.ReadLine());
            double k = double.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());
            double z = double.Parse(Console.ReadLine());

            Console.WriteLine($"Result is:{f.Expr(n, k, m, z)}");
            Console.ReadLine();
        }
    }
}
