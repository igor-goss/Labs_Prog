using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_Prog
{
    internal class Goods
    {
        public Goods()
        {
            Console.WriteLine("Creatin Goods object.");
        }

        protected string Name;
        protected string name
        {
            get { return Name; }
            set { Name = value; }
        }

        protected DateTime ExpirationDate;
        protected DateTime expirationDate
        {
            get { return ExpirationDate; }
            set { ExpirationDate = value; }
        }

        protected Single Price;
        public Single price
        {
            get { return Price; }
            set { Price = value; }
        }
        public virtual void WritePrice() { }
    }
}
