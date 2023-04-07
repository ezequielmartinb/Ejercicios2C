using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    public class Input
    {
        public static double PedirNumeroDouble(string mensaje, string mensajeError)
        {
            double numero;
            Console.WriteLine(mensaje);

            while (double.TryParse(Console.ReadLine(), out numero) == false)
            {
                Console.WriteLine(mensajeError);
            }

            return numero;
        }
    }
}
