using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_Lab3_Prog.Services
{
    public class Class1
    {
        public double Expr(double n, double k, double m, double z)
        {
            double res, x;
            if (z > 1)
                x = Math.Exp(z) + z;
            else
                x = z * z + 1;
            return Math.Sin(n * x) + Math.Cos(k * x) + Math.Log(m * x);
        }
    }
}
