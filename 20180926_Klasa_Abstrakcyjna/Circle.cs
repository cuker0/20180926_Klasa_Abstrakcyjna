using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180926_Klasa_Abstrakcyjna
{
    class Circle : Figure
    {
        public double Radius { get; private set; }
       
    
        public Circle(double r)
        {
            Radius = r;
        }

        public override double Area()
        {
            return Math.Round((Math.PI * Math.Pow(Radius, 2)),4);
        }

        public override double Perimeter()
        {
            return Math.Round((2 * Math.PI * Radius),4);
        }     

        public override void Show()  //ctrl+. -> generatre overrides
        {
            Console.WriteLine("I'm Circle");
            
            base.Show();
         
        }
    }
}
