using Entidades;
namespace Ejercicio30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AutoF1 a1 = new AutoF1("escu1", 1);
            AutoF1 a2 = new AutoF1("escu2", 4);
            AutoF1 a3 = new AutoF1("escu3", 5);
            AutoF1 a4 = new AutoF1("escu1", 1);
            AutoF1 a5 = new AutoF1("escu4", 2);
            Competencia competencia = new Competencia(5, 10);



            if (competencia + a1)
            {
                Console.WriteLine(competencia.MostrarDatos());
            }
            else
            {
                Console.WriteLine("NO SE AGREGO");
            }
            if (competencia + a2)
            {
                Console.WriteLine(competencia.MostrarDatos());
            }
            else
            {
                Console.WriteLine("NO SE AGREGO");
            }
            if (competencia + a3)
            {
                Console.WriteLine(competencia.MostrarDatos());
            }
            else
            {
                Console.WriteLine("NO SE AGREGO");
            }
            if (competencia + a4)
            {
                Console.WriteLine(competencia.MostrarDatos());
            }
            else
            {
                Console.WriteLine("NO SE AGREGO");
            }
            if (competencia + a5)
            {
                Console.WriteLine(competencia.MostrarDatos());
            }
            else
            {
                Console.WriteLine("NO SE AGREGO");
            }
        }
    }
}