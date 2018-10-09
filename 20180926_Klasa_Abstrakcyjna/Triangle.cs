using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180926_Klasa_Abstrakcyjna
{
    class Triangle : Figure
    {
        public int A { get; private set; }
        public int B { get; private set; }
        public double C { get; private set; }

        public Triangle(int a, int b)
        {
            A = a;
            B = b;
            C = Math.Sqrt(Math.Pow(A,2)+Math.Pow(B,2));
        }

        public override double Area()
        {
            return (A * B)/2;
        }

        public override double Perimeter()
        {
            return (A + B + C);
        }

        public override void Show()
        {
            Console.WriteLine("I'm Triangle");
            base.Show();

        }
    }
}
