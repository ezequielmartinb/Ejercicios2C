using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    public class Input
    {
        public static int PedirNumeroEntero(string mensaje, string mensajeError)
        {
            int numero;
            Console.WriteLine(mensaje);

            while (int.TryParse(Console.ReadLine(), out numero) == false)
            {
                Console.WriteLine(mensajeError);
            }

            return numero;
        }

    }
}
