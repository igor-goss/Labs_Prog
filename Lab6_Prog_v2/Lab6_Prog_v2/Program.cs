using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_Prog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("START");

            var sausage = new Sausage();
            sausage.typeOfMeat = "Pork";
            sausage.WriteMeatType();
            sausage.price = 6.99F;
            sausage.WritePrice();

            var groundMeat = new GroundMeat();
            groundMeat.typeOfMeat = sausage.typeOfMeat;
            groundMeat.price = 2.49F;
            groundMeat.WritePrice();
            groundMeat.WriteMeatType();

            var bread = new Bread();
            bread.price = 0.99F;
            bread.typeOfFlour = "White";
            bread.WritePrice();
            bread.WriteTypeOfFlour();
        }
    }
}
