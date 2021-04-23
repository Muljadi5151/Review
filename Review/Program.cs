using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review
{
    class Program
    {
        static void Main(string[] args)
        {
            Pertambahan a1 = new Pertambahan(1, 2);
            Console.WriteLine(a1.Proccess());
            a1.Display();
            Pengurangan a2 = new Pengurangan(10, 5);
            Console.WriteLine(a2.Proccess());
            a2.Display();
            Perkalian a3 = new Perkalian(2, 5);
            Console.WriteLine(a3.Proccess());
            a3.Display();
            Pembagian a4 = new Pembagian(10, 5);
            Console.WriteLine(a4.Proccess());
            a4.Display();
            Console.Read();
        }
        class Pertambahan : DemoAbstract
        {
            public Pertambahan(int a, int b)
            {
                A = a;
                B = b;
            }
            public int A { get; private set; }
            public int B { get; private set; }

            public override int Proccess()
            {
                return A + B;
            }
        }
        class Pengurangan : DemoAbstract
        {
            public Pengurangan(int c, int d)
            {
                C = c;
                D = d;
            }
            public int C { get; private set; }
            public int D { get; private set; }
            public override int Proccess()
            {
                return C - D;
            }
        }
        class Perkalian : DemoAbstract
        {
            public Perkalian(int c, int d)
            {
                C = c;
                D = d;
            }
            public int C { get; private set; }
            public int D { get; private set; }
            public override int Proccess()
            {
                return C * D;
            }
        }
        class Pembagian : DemoAbstract
        {
            public Pembagian(int c, int d)
            {
                C = c;
                D = d;
            }
            public int C { get; private set; }
            public int D { get; private set; }
            public override int Proccess()
            {
                return C / D;
            }
        }
    }
}
