using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP.Class
{
    public class Trapesium : Segitiga
    {
        public double SisiPanjang { get; set; }

        public void HitungLuas()
        {
            Luas = ((Alas + SisiPanjang) / 2.0) * Tinggi;

            Output();
        }

        
    }
}


