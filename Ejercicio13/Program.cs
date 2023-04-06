namespace Ejercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 13.	Desarrollar una clase llamada Conversor, que posea dos métodos de clase (estáticos):
                    string DecimalBinario(int). Convierte un número de entero a binario.
                    int BinarioDecimal(string). Convierte un número binario a entero.

                    NOTA: no utilizar los atajos del lenguaje, hacerlo mediante estructuras repetitivas y de control.

             */

            int numeroDecimal = Conversor.BinarioDecimal("1110");
            string numeroBinario = Conversor.DecimalBinario(14);
            Console.WriteLine(numeroDecimal);
            Console.WriteLine(numeroBinario);
        }
    }
}