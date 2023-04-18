using Entidades;
namespace Ejercicio22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NumeroBinario numeroBinario = (NumeroBinario)"1111"; // 15
            NumeroDecimal numeroDecimal = (NumeroDecimal)8;     // 10110  

            Console.WriteLine($"El numero binario es {numeroBinario.GetNumeroBinario}, sumado con el decimal da un total de {numeroDecimal + numeroBinario}");

            Console.WriteLine($"El numero decimal es {numeroDecimal.GetNumeroDecimal}, sumado con el binario da un total de {(numeroBinario + numeroDecimal)}");

            Console.WriteLine($"El numero binario es {numeroBinario.GetNumeroBinario}, resta con el decimal da un total de {numeroDecimal - numeroBinario}");
            Console.WriteLine($"El numero decimal es {numeroDecimal.GetNumeroDecimal}, resta con el binario da un total de {(numeroBinario - numeroDecimal)}");
            Console.ReadKey();
        }
    }
}