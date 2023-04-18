using Billetes;
namespace Ejercicio20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Euro euros = 1;
            Peso pesos = (Peso)euros;
            Dolar dolares = 100;


            Console.WriteLine("Cantidad de Euros convertidos a Pesos: {0}", pesos.GetCantidad());
            pesos = (Peso)dolares;
            Console.WriteLine("Cantidad de Dolares convertidos a Pesos {0}", pesos.GetCantidad());
        }
    }
}