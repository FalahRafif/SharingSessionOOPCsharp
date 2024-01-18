using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestOOP.Class;


namespace TestOOP
{
    public class Program
    {
        static void Main(string[] args)
        {
            //segitiga
            double a = 5;
            double t = 7;

            //trapesium
            double b = 3;


            //hitung Luas Segitiga dan Trapesium
            ProceduralProgramming(a , t, b);
            OOP(a , t, b);
        }

        private static void ProceduralProgramming(double a, double t, double b)
        {
            double hasilLuasSegitiga = (1.0/2.0)*a*t;
            double hasilLuasTrapesium = ((a + b) / 2.0) * t;


            Console.WriteLine("/////////// Procedural Programming");
            Console.WriteLine("Luas = " + hasilLuasSegitiga);
            Console.WriteLine("Luas = " + hasilLuasTrapesium);
            Console.WriteLine("/////////// Procedural Programming");

        }

        private static void OOP(double a, double t, double b)
        {
            Segitiga segitiga = new Segitiga
            {
                Alas = a,
                Tinggi = t
            };
            Trapesium trapesium = new Trapesium
            {
                Alas = a,
                Tinggi = t,
                SisiPanjang = b
            };

            Console.WriteLine("/////////// OOP");
            segitiga.HitungLuas();
            trapesium.HitungLuas();
            Console.WriteLine("/////////// OOP");




        }


    }
}
