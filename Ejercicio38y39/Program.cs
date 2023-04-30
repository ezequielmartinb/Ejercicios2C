using Entidades;
namespace Ejercicio38y39
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 39";
            Sobrescrito objetoSobrescrito = new SobreSobrescrito();

            Console.WriteLine(objetoSobrescrito.MiMetodo());

            string objeto = "¡Este es mi método ToString sobrescrito!";

            Console.WriteLine("----------------------------------------------");
            Console.Write("Comparación Sobrecargas con String: ");
            Console.WriteLine(objetoSobrescrito.Equals(objeto));

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(objetoSobrescrito.GetHashCode());

            Console.ReadKey();


            /* Console.Title = "Ejercicio 38";
             Sobrescrito objetoSobrescrito = new Sobrescrito();

             Console.WriteLine(objetoSobrescrito.ToString());

             string objeto = "¡Este es mi método ToString sobrescrito!";

             Console.WriteLine("----------------------------------------------");
             Console.Write("Comparación Sobrecargas con String: ");
             Console.WriteLine(objetoSobrescrito.Equals(objeto));

             Console.WriteLine("----------------------------------------------");
             Console.WriteLine(objetoSobrescrito.GetHashCode());

             Console.ReadKey();*/
        }
    }
}