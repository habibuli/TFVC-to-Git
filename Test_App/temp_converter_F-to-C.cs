using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temp_converter_F_to_C
{
    class Program
    {
        static void Main(string[] args)
        {
            int fer, cel, test;

            Console.WriteLine("Please type your fer value: ");

            fer = int.Parse(Console.ReadLine());

            cel = (5 * fer -160) / 9;

            //Console.WriteLine("The " + fer + " degree fer is equal to " + cel + " cel.");
            Console.WriteLine(cel);

            Console.ReadLine();

        }
    }
}
