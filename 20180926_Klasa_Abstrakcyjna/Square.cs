using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180926_Klasa_Abstrakcyjna
{
    class Square : Figure
    {
        public int A { get; private set; }

        public Square(int a)
        {
            A = a;
        }

        public override double Area()
        {
            return Math.Pow(A,2);
        }

        public override double Perimeter()
        {
            return (4 * A);
        }
        public double Diagonal()
        {
            return Math.Sqrt(2)*A;
        }
        //public override void Show()
        //{
        //    Console.WriteLine($"Area: {Area()},Perimeter: {Perimeter()}, Diagonal {Diagonal()}");
        //    Console.ReadKey();
        //}
    }
}
