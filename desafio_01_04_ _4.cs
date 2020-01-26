using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafíos_01_04______4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese los valores de w, t, c");
            double w = double.Parse(Console.ReadLine());
            double t = double.Parse(Console.ReadLine());
            double cgrados = double.Parse(Console.ReadLine());
            double c = cgrados * (Math.PI / 180);


            Console.WriteLine("el valor de x es:");

            //calculando el valor de z
            Double z = t * (Math.Sin(c));

            //calculando el valor de y
            Double y = (Math.Sqrt(Math.Pow(t, 2) - Math.Pow(z, 2)));

            //calculando el valor de x
            Double x = (Math.Sqrt(Math.Pow(w, 2) - Math.Pow(z, 2))) - y;

            Console.WriteLine(x);
            //funciona, (hecho por David Martínez)
        }
    }
}
