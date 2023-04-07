using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
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
        public static char PedirCaracterEspecial(string mensaje, string mensajeError)
        {
            char operacionMatematica;
            bool resultado;
            resultado = char.TryParse(Console.ReadLine(), out operacionMatematica);

            while (resultado == false || (operacionMatematica != '+' && operacionMatematica != '-' && operacionMatematica != '*' && operacionMatematica != '/'))
            {
                Console.WriteLine("ERROR. Reingrese una operacion matematica valida: ");
                resultado = char.TryParse(Console.ReadLine(), out operacionMatematica);
            }
            return operacionMatematica;
        }
        public static char DeseaContinuar(string mensaje, string mensajeError, char caracterValido, char caracterValido2)
        {
            char opcion;
            bool resultado;

            Console.WriteLine(mensaje);

            resultado = char.TryParse(Console.ReadLine(), out opcion);

            while (resultado == false || (opcion != caracterValido && opcion != caracterValido2))
            {
                Console.WriteLine(mensajeError);
                char.TryParse(Console.ReadLine(), out opcion);
            }
            return opcion;
        }
    }
}
