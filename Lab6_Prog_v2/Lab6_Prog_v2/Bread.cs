using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_Prog
{
    internal class Bread : Goods
    {
        public Bread()
        {
            Console.WriteLine("Creating Bread object.");
        }
        String TypeOfFlour;
        public String typeOfFlour
        {
            get { return TypeOfFlour; }
            set { TypeOfFlour = value; }
        }
        public override void WritePrice() => Console.WriteLine($"Price of bread is {price}.");
        public void WriteTypeOfFlour() => Console.WriteLine($"The type of flour is {TypeOfFlour}");
    }
}
