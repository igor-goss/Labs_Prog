using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5_ProgG
{
    internal class Client
    {
        public Client()
        {
            Name = "\0";
            NumOfDeposits = 0;
        }

        string Name;
        public string name
        {
            get { return Name; }
            set { Name = value; }
        }
        static int NumOfDeposits;
        public int numOfDeposits
        {
            get { return NumOfDeposits; }
            set { NumOfDeposits = value; }
        }

        public Deposit[] deposits = new Deposit[NumOfDeposits];

        public void setup()
        {
            for (int i = 0; i < NumOfDeposits; i++)
                deposits[i] = new Deposit();
        }

        public void CreateDeposit(double ammount, double annulaRevenue)
        {
            deposits[0].ammount = ammount;
            deposits[0].annualRevenue = annulaRevenue;
        }
    }
}