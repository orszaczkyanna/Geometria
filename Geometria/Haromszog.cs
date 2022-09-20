using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    class Haromszog
    {
        //A Geometria projectet egészítsd ki egy Haromszog osztállyal, amely az oldalak ismeretében megadja a kerületet és a területet.
        //Nem lehet nulla vagy negatív  oldalhosszúság!
        double oldalA;
        double oldalB;
        double oldalC;

        public double OldalA { get => oldalA; set => oldalA = value; }
        public double OldalB { get => oldalB; set => oldalB = value; }
        public double OldalC { get => oldalC; set => oldalC = value; }

        public Haromszog(double oldalA, double oldalB, double oldalC)
        {
            if (oldalA <= 0 || oldalB <= 0 || oldalC <= 0)
            {
                throw new ArgumentOutOfRangeException("Ezzel az oldalhosszúsággal nem lehet szerkesztenni"); 
            }
            else
            {
                OldalA = oldalA;
                OldalB = oldalB;
                OldalC = oldalC;
            }
        }

        public double Kerulet()
        {
            return oldalA + oldalB + oldalC;
        }

        public double Terulet()
        {
            double s = (oldalA + oldalB + oldalC)/2;
            return Math.Sqrt(s*(s - oldalA)*(s - oldalB)*(s - oldalC));
        }


    }
}
