using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review
{
    class hitungPenjumlahan : Hitung
    {
        private int a, b, c;
        public int A
        {
            get
            {
                return a;
            }
            set
            {
                a = value;
            }
        }
        public int B
        {
            get
            {
                return b;
            }
            set
            {
                b = value;
            }
        }
        public int C
        {
            get
            {
                return c;
            }
            set
            {
                c = value;
            }
        }
        public void Penjumlahan()
        {
            C = A + B;
            Console.WriteLine("Penumlahan dari " + A + " dan " + B + " adalah " + C);
        }
    }
}
