using Entidades;

namespace Ejercicio19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sumador sumador = new Sumador();
            Sumador otroSumador = new Sumador();

            Console.WriteLine(sumador.Sumar(4, 20));
            Console.WriteLine(sumador.Sumar("Juan", "Carlos"));
            Console.WriteLine(((int)sumador));

            Console.WriteLine(otroSumador.Sumar(72, 8));
            Console.WriteLine(otroSumador.Sumar("HOLA", "MUNDO"));

            Console.WriteLine(sumador + otroSumador);
            Console.WriteLine(sumador | otroSumador);

        }
    }
}