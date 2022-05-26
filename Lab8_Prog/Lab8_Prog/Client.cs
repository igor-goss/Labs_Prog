using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_Prog
{
    internal class Client
    {
        string? Name;
        public string? name
        {
            get { return Name; }
            set { Name = value; }
        }
        float? DepositAmmount;
        public float? depositAmmount
        {
            get { return DepositAmmount; }
            set { DepositAmmount = value; }
        }
    }
}
