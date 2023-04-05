namespace Ejercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1.	Ingresar 5 números por consola, 
                    guardándolos en una variable escalar. 
                    Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.
             */

            int[] numeros = new int[5];
            int numeroMaximo = 0;
            int numeroMinimo = 0;
            int acumuladorNumeros = 0;
            float promedioNumeros;
            bool resultado = false;

            Console.Title = "Ejercicio 01";

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Ingrese el numero #{0}", i + 1);
                resultado = int.TryParse(Console.ReadLine(), out numeros[i]);
                if (resultado)
                {
                    acumuladorNumeros += numeros[i];
                    if (i == 0)
                    {
                        numeroMaximo = numeros[i];
                        numeroMinimo = numeros[i];
                    }
                    else if (numeros[i] > numeroMaximo)
                    {
                        numeroMaximo = numeros[i];
                    }
                    else if (numeros[i] < numeroMinimo)
                    {
                        numeroMinimo = numeros[i];
                    }
                }
                else
                {
                    Console.WriteLine("ERROR. NO INGRESO UN NUMERO VALIDO");
                    break;
                }
            }
            if (resultado)
            {
                promedioNumeros = (float)acumuladorNumeros / 5;
                Console.WriteLine("El numero maximo es: {0}\n " +
                                  "El numero minimo es: {1}\n " +
                                  "El promedio de los numeros es: {2}", numeroMaximo, numeroMinimo, promedioNumeros.ToString("0.00"));
            }
        }
    }
}