using System;
namespace Ejercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 2.	Ingresar un número y mostrar: el cuadrado y el cubo del mismo. 
             * Se debe validar que el número sea mayor que cero, caso contrario, 
             * mostrar el mensaje: "ERROR. ¡Reingresar número!".
               Nota: Utilizar el método ‘Pow’ de la clase Math para realizar la operación.
             */

            int numeroIngresado;
            double resultadoCubo;
            double resultadoCuadrado;
            bool resultadoNumeroIngresado;
            Console.Title = "Ejercicio 02";

            Console.WriteLine("Ingrese un numero entero mayor que 0: ");
            resultadoNumeroIngresado = int.TryParse(Console.ReadLine(), out numeroIngresado);

            while (numeroIngresado < 1 || resultadoNumeroIngresado == false)
            {
                Console.WriteLine("ERROR. ¡Reingresar número!");
                Console.WriteLine("Ingrese un numero entero mayor que 0: ");
                resultadoNumeroIngresado = int.TryParse(Console.ReadLine(), out numeroIngresado);
            }

            resultadoCubo = Math.Pow(numeroIngresado, 2);
            resultadoCuadrado = Math.Pow(numeroIngresado, 3);

            Console.WriteLine("El numero ingresado es: {0} y el resultado al cuadrado es: {1}", numeroIngresado, resultadoCuadrado);
            Console.WriteLine("El numero ingresado es: {0} y el resultado al cubo es: {1}", numeroIngresado, resultadoCubo);

            Console.ReadKey();

        }
    }
}