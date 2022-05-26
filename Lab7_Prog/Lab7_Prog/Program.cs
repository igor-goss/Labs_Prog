using System;

namespace Lab7_Prog
{
    public class Program
    {
        static void Main(string[] args)
        {
            Polynom a = new Polynom();
            Console.WriteLine(a.ToString());

            Polynom b = new Polynom(1, 2, 3, 0);
            Console.WriteLine(b.ToString());

            Polynom c = new Polynom(4, 4, 4, 4);
            Console.WriteLine((c + b).ToString());

            Polynom d = new Polynom(5, 5, 5, 5);
            Console.WriteLine((d / 5).ToString());

            Polynom e = new Polynom(1, 1, 1, 0);
            Console.WriteLine((e + new Polynom(0, 0, 0, 1)).ToString());
        }
    }
}