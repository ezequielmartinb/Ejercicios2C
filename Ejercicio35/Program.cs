using Entidades;

namespace Ejercicio35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona unaPersona = new Persona(37332399, "Ezequiel Brañanova");
            DirectorTecnico unDirectorTecnico = new DirectorTecnico("Juan Gelvez", new DateTime(1977, 01, 19));
            DirectorTecnico otroDirectorTecnico = new DirectorTecnico("Juan Gelvez", new DateTime(1977, 01, 19));

            Console.WriteLine(unaPersona.MostrarDatos());
            Console.WriteLine(unDirectorTecnico.MostrarDatos());

            if(unDirectorTecnico == otroDirectorTecnico)
            {
                Console.WriteLine("Hay dos DT iguales");
            }
            else
            {
                Console.WriteLine("No son iguales");
            }
        }
    }
}