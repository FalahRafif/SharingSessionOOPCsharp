using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP.Class
{
    public class Segitiga //class segitiga - parent trapesium
    {
        //property
        public double Alas { get; set; }
        public double Tinggi { get; set; }
        
        protected double Luas { get; set; }

        //fungsi/method
        public void HitungLuas()
        {
            Luas = (1.0 / 2.0) * Alas * Tinggi;

            Output();
        }

        //fungsi/method
        protected void Output()
        {
            Console.WriteLine("Luas : " + Luas);
        }
    }
}
