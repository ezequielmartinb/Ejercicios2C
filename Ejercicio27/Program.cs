namespace Ejercicio27
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> listaDeNumeros = new List<int>();
            Queue<int> colaNumerosPositivos = new Queue<int>();
            Queue<int> colaNumerosNegativos = new Queue<int>();
            Stack<int> stackNumerosPositivos = new Stack<int>();
            Stack<int> stackNumerosNegativos = new Stack<int>();
            Random random = new Random();

            for (int i = 0; i < 20; i++)
            {
                listaDeNumeros.Add(random.Next(-1000, 1000));
                if (listaDeNumeros.Contains(0))
                {
                    listaDeNumeros.Remove(0);
                    listaDeNumeros.Add(random.Next(-1000, 1000));
                }
            }
            Console.WriteLine("LISTA DE NUMEROS");
            foreach (int item in listaDeNumeros)
            {
                Console.WriteLine(item);

            }

            listaDeNumeros.Sort(FuncionCriterioDecreciente);
            Console.WriteLine("LISTA NUMEROS POSITIVOS ORDENADA DECRECIENTE");
            foreach (int item in listaDeNumeros)
            {
                if (item > 0)
                {
                    Console.WriteLine(item);
                    colaNumerosPositivos.Enqueue(item);
                }
            }
            listaDeNumeros.Sort(FuncionCriterioCreciente);
            Console.WriteLine("LISTA NUMEROS NEGATIVOS ORDENADA CRECIENTE");
            foreach (int item in listaDeNumeros)
            {
                if (item < 0)
                {
                    Console.WriteLine(item);
                    colaNumerosNegativos.Enqueue(item);

                }
            }
            Console.WriteLine("LISTA NUMEROS POSITIVOS ORDENADA DECRECIENTE COLA");
            foreach (int item in colaNumerosPositivos)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("LISTA NUMEROS NEGATIVOS ORDENADA DECRECIENTE COLA");
            foreach (int item in colaNumerosNegativos)
            {
                Console.WriteLine(item);
            }
            listaDeNumeros.Sort(FuncionCriterioCreciente);
            foreach (int item in listaDeNumeros)
            {
                if (item > 0)
                {
                    stackNumerosPositivos.Push(item);
                }
            }
            listaDeNumeros.Sort(FuncionCriterioDecreciente);
            foreach (int item in listaDeNumeros)
            {
                if (item < 0)
                {
                    stackNumerosNegativos.Push(item);
                }
            }
            Console.WriteLine("LISTA NUMEROS POSITIVOS ORDENADA DECRECIENTE STACK");
            foreach (int item in stackNumerosPositivos)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("LISTA NUMEROS NEGATIVOS ORDENADA DECRECIENTE STACK");
            foreach (int item in stackNumerosNegativos)
            {
                Console.WriteLine(item);
            }

        }
        static int FuncionCriterioDecreciente(int n1, int n2)
        {
            return n2 - n1;
        }
        static int FuncionCriterioCreciente(int n1, int n2)
        {
            return n1 - n2;
        }

    }
}

