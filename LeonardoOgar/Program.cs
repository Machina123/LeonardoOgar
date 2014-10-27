using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeonardoOgar
{
    class Program
    {
        static void Main(string[] args)
        {
            Ellipsis pszemeg = new Ellipsis();

            Console.WriteLine(" Pole: " + pszemeg.Area());
            Console.WriteLine("Obwod: " + pszemeg.Circumference());

            Console.ReadKey();
        }
    }
}
