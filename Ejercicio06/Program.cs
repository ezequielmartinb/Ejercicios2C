using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
namespace Ejercicio06
{
    internal class Program
    {
        /*
         * 	6.	Escribir un programa que determine si un año es bisiesto.
         * 	
                Un año es bisiesto si es múltiplo de 4.         
                Los años múltiplos de 100 no son bisiestos, 
                salvo si ellos también son múltiplos de 400. Por ejemplo: el año 2000 es bisiesto pero 1900 no.

                Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos en ese rango.
                Nota: Utilizar estructuras repetitivas, selectivas y la función módulo (%).
         */
        static void Main(string[] args)
        {
            int anioMinimoIngresado = PedirNumero("Ingrese un año minimo: ", "ERROR. Año minimo invalido. Reingrese año: ", 1, 9999);
            int anioMaximoIngresado = PedirNumero("Ingrese un año maximo: ", "ERROR. Año maximo invalido. Reingrese año: ", anioMinimoIngresado, 9999);

            Console.WriteLine("El año ingresado es: {0}", anioMinimoIngresado);
            Console.WriteLine("El año ingresado es: {0}", anioMaximoIngresado);

            Console.WriteLine($"Los años bisiestos entre {anioMinimoIngresado} y {anioMaximoIngresado} son: {EsBisiesto(anioMinimoIngresado, anioMaximoIngresado)}");

        }

        static int PedirNumero(string mensajeValido, string mensajeError, int rangoMinimo, int rangoMaximo)
        {
            bool resultado;
            int numero;

            Console.WriteLine(mensajeValido);
            resultado = int.TryParse(Console.ReadLine(), out numero);

            while (resultado == false || numero <= rangoMinimo || numero > rangoMaximo)
            {
                Console.WriteLine(mensajeError);
                resultado = int.TryParse(Console.ReadLine(), out numero);
            }

            return numero;
        }

        static string EsBisiesto(int anioMinimo, int anioMaximo)
        {
            string aniosBisiestos = "";
            bool banderaDelPrimero = true;

            for (int i = anioMinimo; i <= anioMaximo; i++)
            {
                if (i % 4 == 0 || (i % 100 == 0 && i % 400 == 0))
                {
                    if (banderaDelPrimero == true)
                    {
                        aniosBisiestos = string.Concat(aniosBisiestos, i.ToString());
                    }
                    else
                    {
                        aniosBisiestos = string.Concat(aniosBisiestos, "-", i.ToString());
                    }
                    banderaDelPrimero = false;
                }
            }
            return aniosBisiestos;
        }
    }
}