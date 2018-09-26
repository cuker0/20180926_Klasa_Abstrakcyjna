using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180926_Klasa_Abstrakcyjna
{
    abstract class Figure
    {
        public abstract double Area();
        public abstract double Perimeter();

        public virtual void Show()
        {
            Console.WriteLine($"Area: {Area()}, Perimeter: {Perimeter()}");
            Console.ReadLine();
        }
    }
}
