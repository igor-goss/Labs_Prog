using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_Prog
{
    internal class Sausage : Meat
    {
        public Sausage()
        {
            Console.WriteLine("Creating Sausage object.");
        }
        override public void WriteMeatType() => Console.WriteLine($"The type of meat in the sausage is {TypeOfMeat}.");
        override public void WritePrice() => Console.WriteLine($"Price of sausage is {price}.");
    }
}
