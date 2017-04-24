using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DatingGame
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] Boys = new string[5]{ "David", "Joe", "Darius", "Pavan", "Travor" };
            Random rnd1 = new Random();
            Console.WriteLine(Boys[rnd1.Next(0, 4)]);

            string[] Girls = new string[5] { "Ashly", "Linda", "Joy", "Tracy", "Amberly" };
            Random rnd2 = new Random();
            Console.WriteLine(Girls[rnd2.Next(0,4)]);
            Console.ReadLine();

        }
    }
}
