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
            //    TestList();

            FigureList();
            Console.ReadKey();
            return;
            /*


            Figure[] figures = new Figure[5];

            figures[0] = new Square(2);
            figures[1] = new Circle(3.14);
            figures[2] = new Square(5);
            figures[3] = new Triangle(25, 66);
            figures[4] = new Rectangle(2, 4);

            foreach (Figure figure in figures)
            {
                figure.Show();
            }
            Console.ReadLine();

            Square sq = new Square(2);
            Circle cir = new Circle(3);

            sq.CompareTo(cir);
            */

        }

        static void TestList()
        {
            // inicjalizacja listy
            List<string> names = new List<string>()
        {
            "Piotr",
            "Adam",
            "Marcin",
            "Andrzej",
            "Robert"
        };

            //PrintList(names);

            names.Add("Marcin");
            names.Insert(0, "Krzysiek");
         //   PrintList(names);

            //   names.Remove("Adam");
            //   PrintList(names);

            names.RemoveAt(names.Count - 1);
        //    PrintList(names);

            Console.WriteLine($"Moje imie jest pod indeksem: {names.IndexOf("Marcin")}");

            Console.WriteLine($"Czy na liscie znajduje sie imie Anastazy: { names.Contains("Anastazy") }");

        //    PrintList(names.FindAll(LongerThan5));

            //   names.RemoveAll(name => (name.Length % 2) != 0);

            //  names.Sort(CompareStringLength); // sortowanie od najkrotszego do najdluzszego
         //   PrintList(names);

            names.Sort((x, y) =>
            {
                int result = 0;
                if (x.Length > y.Length)
                    result = 1;
                else if (x.Length < y.Length)
                    result = -1;
                return result;
            });

            names.Clear();
        //    PrintList(names);

            Console.ReadLine();
        }

        /*
        static int comparestringlength(string x, string y)
        {
            int result = 0;
            if (x.length > y.length)
                result = 1;
            else if (x.length < y.length)
                result = -1;
            return result;
        }
        */

        static bool LongerThan5(string str)
        {
            return str.Length > 5;
        }

        private static void FigureList()
        {
            List<Figure> figurelist = new List<Figure>()
             {
            new Square(2),
            new Triangle(2, 5),
            new Circle(5),
            new Circle(6),
            new Rectangle(5,7)
             };

            figurelist.Sort();

            foreach (var item in figurelist)
            {
                item.Show();
            }
        }
        

    }
    /*
    static void PrintList(IEnumerable<string> list)
    {
        Console.WriteLine("#############################");
        Console.WriteLine("Items in list");

        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine(Environment.NewLine);
    }
    */
}

