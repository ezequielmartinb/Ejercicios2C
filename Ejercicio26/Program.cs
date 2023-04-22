namespace Ejercicio26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNumeros = new int[20];
            Random random = new Random();

            for (int i = 0; i < arrayNumeros.Length; i++)
            {
                arrayNumeros[i] = random.Next(-1000, 1000);
                if (arrayNumeros[i] == 0)
                {
                    arrayNumeros[i] = random.Next(-1000, 1000);
                }
            }
            Console.WriteLine("NUMEROS SIN ORDENAR");
            foreach (int numeros in arrayNumeros)
            {
                Console.WriteLine(numeros);
            }

            Array.Sort(arrayNumeros, FuncionCriterioDecreciente);
            Console.WriteLine("NUMEROS POSITIVOS ORDENADOS");
            foreach (int numeros in arrayNumeros)
            {
                if (numeros > 0)
                {
                    Console.WriteLine(numeros);
                }
            }
            Console.WriteLine("NUMEROS NEGATIVOS ORDENADOS");
            Array.Sort(arrayNumeros);
            foreach (int numeros in arrayNumeros)
            {
                if (numeros < 0)
                {
                    Console.WriteLine(numeros);
                }
            }
        }
        static int FuncionCriterioDecreciente(int n1, int n2)
        {
            return n2 - n1;
        }

    }
}