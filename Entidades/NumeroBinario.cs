using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class NumeroBinario
    {
        private string numeroBinario;

        private NumeroBinario(string numeroBinario)
        {
            this.numeroBinario = numeroBinario;
        }

        public string GetNumeroBinario { get => numeroBinario; }

        public static double BinarioDecimal(string numeroEnBinario) // Convertir de binario a entero
        {
            double numeroDecimal = 0;
            for (int i = 0; i < numeroEnBinario.Length; i++)
            {
                if (numeroEnBinario[i] == '1')
                {
                    numeroDecimal += Math.Pow(2, numeroEnBinario.Length - (i + 1));
                }
            }
            return numeroDecimal;
        }
        public static explicit operator NumeroBinario(string numero)
        {
            return new NumeroBinario(numero);
        }

        public static implicit operator NumeroBinario(NumeroDecimal numero)
        {
            return new NumeroBinario(NumeroDecimal.DecimalBinario(numero.GetNumeroDecimal));
        }
        public static string operator +(NumeroBinario b, NumeroDecimal d)
        {
            double suma = (BinarioDecimal(b.GetNumeroBinario) + d.GetNumeroDecimal);
            return NumeroDecimal.DecimalBinario(suma);
        }
        public static string operator -(NumeroBinario b, NumeroDecimal d)
        {
            double resta = (BinarioDecimal(b.GetNumeroBinario) - d.GetNumeroDecimal);
            return NumeroDecimal.DecimalBinario(resta);
        }
        public static bool operator ==(NumeroBinario b, NumeroDecimal d)
        {
            return b.GetNumeroBinario == NumeroDecimal.DecimalBinario(d.GetNumeroDecimal);
        }
        public static bool operator !=(NumeroBinario b, NumeroDecimal d)
        {
            return !(b == d);
        }
    }
}
