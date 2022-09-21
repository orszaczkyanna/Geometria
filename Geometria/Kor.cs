using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    internal class Kor
    {            
        double sugar;
        double atmero;

        public Kor(double sugar)
        {
            Sugar = sugar;
        }


        //public double Sugar { get => sugar; set => sugar = value; }
        //public double Atmero { get => atmero; set => atmero = value; }

        public double Sugar {
            get => sugar;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException($"A '{value}' értékkel nem szerkeszthető kör");
                }
                else
                {
                    sugar = value;
                }
            }
        }





        public double Atmero { get => 2*sugar;}


        public double Kerulet()
        {
            return sugar * 2 * Math.PI;
        }

        public double Terulet()
        {
            return sugar * sugar * Math.PI;
        }
    }


}
