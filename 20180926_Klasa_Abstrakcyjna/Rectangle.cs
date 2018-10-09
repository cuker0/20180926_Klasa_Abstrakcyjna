using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180926_Klasa_Abstrakcyjna
{
    class Rectangle :Figure
    {
        
        public int A { get; private set; }
        public int B { get; private set; }

        public Rectangle(int a, int b)
        {
            A = a;
            B = b;
        }
        public override double Area()
        {
            return A*B;
        }

        public override double Perimeter()
        {
            return (2*A + 2*B);
        }

        public override void Show()
        {
            Console.WriteLine("I'm Rectangle");
            base.Show();

        }
    }
}

