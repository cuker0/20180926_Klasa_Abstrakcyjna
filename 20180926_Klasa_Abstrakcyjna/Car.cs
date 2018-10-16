using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180926_Klasa_Abstrakcyjna
{
    class Car : Vehicle
    {
        public int CurrentGear { get; set; }

        public override void Show()
        {
            Console.WriteLine("I'm Car");
            Console.WriteLine($"CurrentGear: {CurrentGear}");
            base.Show();
        }
    }
}
