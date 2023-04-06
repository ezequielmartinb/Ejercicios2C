using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    public class Conversor
    {
        public static string DecimalBinario(int numeroEntero) // Convertir de entero a binario
        {
            int auxNumeroEntero = numeroEntero;
            int resto;
            string numeroBinario = "";

            while (auxNumeroEntero > 0)
            {
                resto = auxNumeroEntero % 2;
                if (auxNumeroEntero % 2 == 0)
                {
                    numeroBinario = "0" + numeroBinario;
                }
                else
                {
                    numeroBinario = "1" + numeroBinario;
                }
                auxNumeroEntero = auxNumeroEntero / 2;

            }
            return numeroBinario;

        }
        public static int BinarioDecimal(string numeroEnBinario) // Convertir de binario a entero
        {
            double numeroDecimal = 0;
            for (int i = 0; i < numeroEnBinario.Length; i++)
            {
                if (numeroEnBinario[i] == '1')
                {
                    numeroDecimal += Math.Pow(2, numeroEnBinario.Length - (i + 1));
                }
            }
            return (int)numeroDecimal;
        }
    }
}
