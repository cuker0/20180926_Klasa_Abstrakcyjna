using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180926_Klasa_Abstrakcyjna
{ 
    class Airplane : Vehicle
    {
        public int Altitude { get; set; }

        public override void Show()
        {
            Console.WriteLine("I'm Airplane");
            Console.WriteLine($"Altitude: {Altitude}");
            base.Show();
        }
    }
}
