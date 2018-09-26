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
        
            Figure[] figures = new Figure[3];

            figures[0] = new Square(2);
            figures[1] = new Circle(3.14);
            figures[2] = new Square(5);

            foreach (Figure figure in figures)
            {
                figure.Show();
            }
            Console.ReadLine();
        }
    }
}
