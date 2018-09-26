using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180926_Klasa_Abstrakcyjna
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure Square = new Square(3);
            Square.Show();

            Figure Circle = new Circle(5);
            Circle.Show();
        }
    }
}
