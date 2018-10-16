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

            

        Figure[] figures = new Figure[5];

            figures[0] = new Square(2);
            figures[1] = new Circle(3.14);
            figures[2] = new Square(5);
            figures[3] = new Triangle(25,66);
            figures[4] = new Rectangle(2, 4);

            foreach (Figure figure in figures)
            {
                figure.Show();
            }
            Console.ReadLine();

            Square sq = new Square(2);
            Circle cir = new Circle(3);

            sq.CompareTo(cir);
        }
    }
}
