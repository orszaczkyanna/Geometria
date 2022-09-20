using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kor kor = new Kor();
            Kor kor = new Kor(5);
            try
            {
                kor.Sugar = 8;
                Console.WriteLine($"A kör sugara: {kor.Sugar:N2}\tkerülete: {kor.Kerulet():N2}\tterülete: {kor.Terulet():N2}");

                kor.Sugar = 23;
                Console.WriteLine($"A kör sugara: {kor.Sugar:N2}\tkerülete: {kor.Kerulet():N2}\tterülete: {kor.Terulet():N2}");
                kor.Sugar = 9;
                Console.WriteLine($"A kör sugara: {kor.Sugar:N2}\tkerülete: {kor.Kerulet():N2}\tterülete: {kor.Terulet():N2}");
                kor.Sugar = -2;
                Console.WriteLine($"A kör sugara: {kor.Sugar:N2}\tkerülete: {kor.Kerulet():N2}\tterülete: {kor.Terulet():N2}");
                kor.Sugar = 11;
                Console.WriteLine($"A kör sugara: {kor.Sugar:N2}\tkerülete: {kor.Kerulet():N2}\tterülete: {kor.Terulet():N2}");

            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }


            try
            {
                Haromszog haromszog = new Haromszog(3, 4, 5);
                Console.WriteLine($"\n\nA háromszög\nkerülete: {haromszog.Kerulet():N2}\nterülete: {haromszog.Terulet():N2}");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
                        
            
            Console.WriteLine("Program vége");
            Console.ReadKey();
        }
    }
}
