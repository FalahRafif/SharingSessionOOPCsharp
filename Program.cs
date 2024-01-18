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

        /// <summary>
        /// Procedural Programming, Tidak adanya 4 pilar dari OOP dan kode langsung di buat begitu sahja
        /// </summary>
        /// <param name="a"></param>
        /// <param name="t"></param>
        /// <param name="b"></param>
        private static void ProceduralProgramming(double a, double t, double b)
        {
            double hasilLuasSegitiga = (1.0/2.0)*a*t;
            double hasilLuasTrapesium = ((a + b) / 2.0) * t;


            Console.WriteLine("/////////// Procedural Programming");
            Console.WriteLine("Luas = " + hasilLuasSegitiga);
            Console.WriteLine("Luas = " + hasilLuasTrapesium);
            Console.WriteLine("/////////// Procedural Programming");

        }

        /// <summary>
        /// OOP, terdapat 4 pilar/prinsip yang di pakai
        /// </summary>
        /// <param name="a"></param>
        /// <param name="t"></param>
        /// <param name="b"></param>
        private static void OOP(double a, double t, double b)
        {
            //encasulation
            Segitiga segitiga = new Segitiga //instance dari class segitiga menjadi object segitiga
            {
                //abstaction
                Alas = a,
                Tinggi = t
            };
            //encasulation
            Trapesium trapesium = new Trapesium //instance dari class trapesium menjadi object trapesium
            {
                //abstaction
                Alas = a,
                Tinggi = t,
                SisiPanjang = b
            };

            Console.WriteLine("/////////// OOP");

            //overiding
            segitiga.HitungLuas();
            trapesium.HitungLuas();
            Console.WriteLine("/////////// OOP");




        }


    }
}
