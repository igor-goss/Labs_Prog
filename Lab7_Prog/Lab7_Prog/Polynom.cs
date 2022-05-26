using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_Prog
{
    internal class Polynom
    {
        int a, b, c, d;

        public Polynom()
        {
            a = 0;
            b = 0;
            c = 0;
            d = 0;
        }

        public Polynom(int a, int b, int c, int d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }

        public static Polynom operator ++ (Polynom a)
        {
            return new Polynom(a.a, a.b, a.c, a.d + 1);
        }

        public static Polynom operator -- (Polynom a)
        {
            return new Polynom(a.a, a.b, a.c, a.d - 1);
        }

        public static Polynom operator + (Polynom a, Polynom b)
        {
            Polynom pol = new Polynom();
            pol.a = a.a + b.a;
            pol.b = b.b + a.b;
            pol.c = a.c + b.c;
            pol.d = a.d + b.d;
            return pol;
        }

        public static Polynom operator - (Polynom a, Polynom b)
        {
            Polynom pol = new Polynom();
            pol.a = a.a - b.a;
            pol.b = b.b - a.b;
            pol.c = a.c - b.c;
            pol.d = a.d - b.d;
            return pol;
        }

        public static Polynom operator * (Polynom a, int b)
        {
            Polynom pol = new Polynom();
            pol.a = a.a * b;
            pol.b = a.b * b;
            pol.c = a.c * b;
            pol.d = a.d * b;
            return pol;
        }

        public static Polynom operator / (Polynom a, int b)
        {
            return new Polynom(a.a / b, a.b / b, a.c / b, a.d / b);
        }

        public static bool operator == (Polynom a, Polynom b)
        {
            if (a.a == b.a && a.b == b.b && a.c == b.c && a.d == b.d)
                return true;
            else
                return false;
        }

        public static bool operator != (Polynom a, Polynom b)
        {
            if (a.a != b.a || a.b != b.b || a.c != b.c || a.d != b.d)
                return true;
            else
                return false;
        }

        public static bool operator true (Polynom a)
        {
            if (a.a == 0 && a.b == 0 && a.c == 0 && a.d == 0)
                return false;
            else 
                return true;
        }

        public static bool operator false(Polynom a)
        {
            if (a.a == 0 && a.b == 0 && a.c == 0 && a.d == 0)
                return true;
            else
                return false;
        }

        public override string ToString()
        {
            return $"{a}x + {b}y + {c}z + {d}";
        }
    }
}
