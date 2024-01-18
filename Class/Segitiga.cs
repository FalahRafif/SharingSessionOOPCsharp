using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP.Class
{
    public class Segitiga
    {
        public double Alas { get; set; }
        public double Tinggi { get; set; }
        
        protected double Luas { get; set; }

        public void HitungLuas()
        {
            Luas = (1.0 / 2.0) * Alas * Tinggi;

            Output();
        }

        protected void Output()
        {
            Console.WriteLine("Luas : " + Luas);
        }
    }
}
