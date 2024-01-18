using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP.Class
{
    public class Trapesium : Segitiga //class trapesium - child dari parent segitiga
    {
        //property
        public double SisiPanjang { get; set; }

        //fungsi/method - Polymorphism / overiding dari parent segitiga
        public void HitungLuas()
        {
            Luas = ((Alas + SisiPanjang) / 2.0) * Tinggi;

            Output();
        }

        
    }
}


