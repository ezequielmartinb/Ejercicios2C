using System.Net.Http.Headers;

namespace Ejercicio04
{
    internal class Program
    {
        /*
         * 4.	Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos 
                (excluido el mismo) que son divisores del número.
                El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.
                Escribir una aplicación que encuentre los 4 primeros números perfectos.
                Nota: Utilizar estructuras repetitivas y selectivas.

         */
        static void Main(string[] args)
        {
            string numeroPerfecto = CalcularNumeroPerfecto(5);
            Console.Title = "Ejercicio 04";

            Console.WriteLine("Los 4 primeros numeros perfectos son: {0}", numeroPerfecto);
        }
        static string CalcularNumeroPerfecto(int cantidadDeNumerosPerfectos)
        {
            double i = 0;
            double primeraPotencia;
            double segundaPotencia;
            double numeroPerfecto;
            int contador = 0;
            string numerosPerfectos = "";

            do
            {
                primeraPotencia = Math.Pow(2, (i - 1));
                segundaPotencia = Math.Pow(2, i);
                segundaPotencia--;
                numeroPerfecto = primeraPotencia * segundaPotencia;
                if (EsPrimo(segundaPotencia) && EsPrimo(i))
                {
                    numerosPerfectos = numerosPerfectos + numeroPerfecto.ToString() + "-";
                    contador++;
                }
                i++;
            } while (contador != cantidadDeNumerosPerfectos);

            return numerosPerfectos;
        }
        static bool EsPrimo(double numero)
        {
            bool resultado = false;
            int contador = 0;

            for (int i = 1; i < numero; i++)
            {
                if (numero % i == 0)
                {
                    contador++;
                }
            }
            if (contador == 1)
            {
                resultado = true;
            }
            return resultado;
        }
    }
}