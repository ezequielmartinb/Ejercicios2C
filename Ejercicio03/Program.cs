namespace Ejercicio03
{
    internal class Program
    {
        /*
         3.	Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.
            Nota: Utilizar estructuras repetitivas, selectivas y la función módulo (%). 
         */
        static void Main(string[] args)
        {
            int numeroIngresado;
            string numeroAntecesores = "";
            bool resultado;
            Console.Title = "Ejercicio 03";

            Console.WriteLine("Ingrese un numero entero: ");
            resultado = int.TryParse(Console.ReadLine(), out numeroIngresado);
            while (resultado == false)
            {
                Console.WriteLine("ERROR. Reingrese un numero entero: ");
                resultado = int.TryParse(Console.ReadLine(), out numeroIngresado);
            }
            numeroAntecesores = NumerosPrimosAntecesores(numeroIngresado);

            if (EsPrimo(numeroIngresado) == true || numeroIngresado == 1)
            {
                if (numeroAntecesores == "")
                {
                    Console.WriteLine($"El numero ingresado {numeroIngresado} es primo y no tiene numeros antecesores");
                }
                else
                {
                    Console.WriteLine($"El numero ingresado {numeroIngresado} es primo y sus antecesores son: {numeroAntecesores}");
                }
            }
            else
            {
                numeroAntecesores = NumerosPrimosAntecesores(numeroIngresado);

                Console.WriteLine($"El numero ingresado {numeroIngresado} NO es primo pero sus antecesores que son primos son: {numeroAntecesores} ");
            }
        }
        static bool EsPrimo(int numero)
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
        static string NumerosPrimosAntecesores(int numero)
        {
            string resultado = "";
            numero--;
            while (numero != 0)
            {
                if (EsPrimo(numero))
                {
                    resultado = string.Concat(resultado, numero.ToString(), "-");
                }
                numero--;
            }

            return resultado;
        }
    }
}