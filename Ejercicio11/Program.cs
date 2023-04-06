
namespace Ejercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 11.	Realizar una clase llamada Validación que posea un método estático llamado Validar, 
             *      que posea la siguiente firma: bool Validar(int valor, int min, int max):
             *      
                        a.	valor: dato a validar
                        b.	min y max: rango en el cual deberá estar la variable valor.

                    Pedir al usuario que ingrese 10 números enteros. Validar con el método desarrollado 
                    anteriormente que estén dentro del rango -100 y 100.

                    Terminado el ingreso mostrar el valor mínimo, el valor máximo y el promedio.
                    Nota: Utilizar variables escalares, NO utilizar vectores.

             */
            int numero;
            int minimo = 0;
            int maximo = 0;
            int acumulador = 0;
            float promedio;
            bool flag = false;
            bool resultadoTryParse;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un numero entre -100 y 100 #{0}: ", i + 1);
                resultadoTryParse = int.TryParse(Console.ReadLine(), out numero);
                while (resultadoTryParse == false || Validacion.Validar(numero, -100, 100) == false)
                {
                    Console.WriteLine("ERROR. Ingrese un numero entre -100 y 100 #{0}: ", i + 1);
                    resultadoTryParse = int.TryParse(Console.ReadLine(), out numero);
                }
                if (Validacion.Validar(numero, -100, 100))
                {
                    acumulador += numero;
                    if (flag == false)
                    {
                        minimo = numero;
                        maximo = numero;
                        flag = true;
                    }
                    else if (numero < minimo)
                    {
                        minimo = numero;
                    }
                    else if (numero > maximo)
                    {
                        maximo = numero;
                    }
                }
            }
            promedio = (float)acumulador / 10;
            Console.WriteLine($"El numero minimo ingresado es: {minimo}\n" +
                              $"El numero maximo ingresado es: {maximo}\n" +
                              $"El promedio de los numeros ingresados es: {promedio}");

        }
    }
}