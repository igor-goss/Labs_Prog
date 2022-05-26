using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5_ProgG
{
    internal class Deposit
    {
        private double Ammount = 10000;
        public double ammount
        {
            get { return Ammount; }
            set { Ammount = value; }
        }

        private double AnnualRevenue = 10;
        public double annualRevenue
        {
            get { return AnnualRevenue; }
            set { AnnualRevenue = value; }
        }

        public double CalcRevenue(int period)
        {
            double revenue = 0;
            for (int i = 0; i < period; i++)
                revenue += Ammount * AnnualRevenue * 12 / 100;
            return revenue;
        }
    }
}