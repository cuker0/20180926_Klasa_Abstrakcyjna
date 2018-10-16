using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180926_Klasa_Abstrakcyjna
{
    abstract class Vehicle :IPrintable,IMovable
    {
        public int CurrentSpeed { get; private set; }

        public void SpeedUp (int speed)
        {
            CurrentSpeed += speed;
        }

        public virtual void Show()
        {
            Console.WriteLine($"Current speed: {CurrentSpeed}");
            Console.ReadKey();
        }

        public void Move()
        {
            throw new NotImplementedException();
        }
    }
}
