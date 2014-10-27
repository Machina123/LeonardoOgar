using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeonardoOgar
{
    class Ellipsis
    {
        private double a;

        // public double a { get; set;}

        private double b;

        /// <summary>
        /// Półoś wielka
        /// </summary>
        public double A
        {
            get { return a; }

            set { a = value; }
        }

        /// <summary>
        /// Półoś mała
        /// </summary>
        public double B
        {
            get { return b; }

            set { b = value; }
        }


        public Ellipsis()
        {
            
            try
            {
                Console.Write("Podaj wielkosc wielkiej polosi: ");
                a = double.Parse(Console.ReadLine());

                Console.Write("Podaj wielkosc malej polosi: ");
                b = double.Parse(Console.ReadLine());
            }
            catch(Exception e)
            {
                Console.WriteLine("Wystapil blad: {0}", e.Message.ToString());
                Console.ReadKey();
                System.Environment.Exit(-1);
            }
    
        }

        public Ellipsis(double _a, double _b)
        {
            a = _a;
            b = _b;
        }

        /// <summary>
        /// Pole powierzchni
        /// </summary>
        /// <returns>Pole elipsy</returns>
        public double Area()
        {
            return Math.PI * a * b;
        }

        /// <summary>
        /// Obwód elipsy
        /// </summary>
        /// <returns></returns>
        public double Circumference()
        {
            return Math.PI * ( (1.5 * (a + b)) - Math.Sqrt(a * b));
        }

    }
}
