using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_Prog
{
    internal class Meat : Goods
    {
        public Meat()
        {
            Console.WriteLine("Creating Meat object.");
        }
        protected string TypeOfMeat;
        public string typeOfMeat
        {
            get { return TypeOfMeat; }
            set { TypeOfMeat = value; }
        }

        public virtual void WriteMeatType() => Console.WriteLine($"The meat type is {TypeOfMeat}.");

        override public void WritePrice() => Console.WriteLine($"Price of meat is {price}.");
    }
}
