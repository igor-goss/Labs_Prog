using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_Lab3_Prog
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var clas = new Class1();
            Console.Write("Result of the expression: ");
            Console.WriteLine(clas.Function(2) + clas.Function(3) + clas.Function(4));
            Console.ReadLine();
        }
    }
}
