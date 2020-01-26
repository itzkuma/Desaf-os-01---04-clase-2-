using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafíos_01_04____2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese los valores de d, b, y");
            double dgrados = double.Parse(Console.ReadLine());
            double bgrados = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double d = dgrados * (Math.PI / 180);
            double b = bgrados * (Math.PI / 180);

            Console.WriteLine("el valor de z es:");

            //calculando el valor de a
            double agrados = 180 - dgrados - bgrados - 90;
            double a = agrados * (Math.PI / 180);
            //si funciona

            //encontrando t
            double t = y / (Math.Sin(a));
            //si funciona

            //encontrando z
            Double z = t * (Math.Cos(a));

            Console.WriteLine(z);
            //funciona, (hecho por David Martínez)
        }
    }
}
