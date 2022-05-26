using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_Prog
{
    internal class GroundMeat : Meat
    {
        override public void WriteMeatType() => Console.WriteLine($"The type of meat in the ground meat is {TypeOfMeat}");
    }
}
