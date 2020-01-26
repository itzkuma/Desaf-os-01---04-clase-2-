using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafíos_01_04_____3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese los valores de w, d, x");
            double w = double.Parse(Console.ReadLine());
            double dgrados = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double d = dgrados * (Math.PI / 180);
            

            Console.WriteLine("el valor de y es:");

            //calculando el valor de z
            Double z = w * (Math.Sin(d));

            //calculando el valor de y
            Double y = (Math.Sqrt (Math.Pow(w, 2) - Math.Pow(z, 2))) - x;

            Console.WriteLine(y);
            //funciona, (hecho por David Martínez)
        }
    }
}
