using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafíos_01___04___1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine ("Ingrese los valores de b, z, y");
            double bgrados = double.Parse (Console.ReadLine());
            double z = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double b = bgrados * (Math.PI / 180);

            Console.WriteLine("el valor de x es:");

            //calculando el valor de t 
            double t = Math.Sqrt( (Math.Pow(z, 2)) + (Math.Pow(y, 2)));
            //si funciona

            //calculando el valor de a
            double a = Math.Atan (y / z);
            double agrados = a * (180/ Math.PI);
            //si funciona, recordar para las proximas operaciones poner agrados.

            //calculando el valor de w
            double w = (z / (Math.Cos(b + a)));
            
            //recordar que este programa trabaja en radianes
            //si funciona

            //calculando el valor de X (el valor que me piden)
            double xy = Math.Sqrt((Math.Pow(w, 2)) - (Math.Pow(z, 2)));
            double x = xy - y;

            Console.WriteLine(x);
            //funciona, (hecho por David Martínez)

       
            
        }
    }
}
