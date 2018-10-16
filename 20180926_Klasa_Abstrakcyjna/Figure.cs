using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180926_Klasa_Abstrakcyjna
{
    public enum Colors
    {
        White,
        Yellow,
        Blue,
        Green,
        Red,
        Orange
    }

   abstract class Figure : IPrintable, IMovable, IComparable<Figure>
    {
        public abstract double Area();
        public abstract double Perimeter();

        public Colors Color { get; set; }

        public virtual void Show()
        {
            Console.WriteLine($"Area: {Area()}, Perimeter: {Perimeter()}\n");         
        }

        public void Move()
        {
            throw new NotImplementedException();
        }

        public int CompareTo(Figure other)
        {
            int result = 0;

            if (this.Area() == other.Area()) result = 0;

            else if (this.Area() > other.Area()) result = 1;

            else if (this.Area() < other.Area()) result = -1;

            return result;
           
        }
    }
}

