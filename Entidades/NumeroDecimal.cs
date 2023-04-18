using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class NumeroDecimal
    {
        private double numeroDecimal;

        private NumeroDecimal(double numeroDecimal)
        {
            this.numeroDecimal = numeroDecimal;
        }

        public double GetNumeroDecimal { get => numeroDecimal; }

        public static string DecimalBinario(double numeroEntero) // Convertir de entero a binario
        {
            int auxNumeroEntero = (int)numeroEntero;
            int resto;
            string numeroBinario = "";

            if (auxNumeroEntero < 0)
            {
                auxNumeroEntero = auxNumeroEntero * -1;
            }
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

        public static double operator +(NumeroDecimal d, NumeroBinario b)
        {
            return d.GetNumeroDecimal + NumeroBinario.BinarioDecimal(b.GetNumeroBinario);
        }
        public static double operator -(NumeroDecimal d, NumeroBinario b)
        {
            return d.GetNumeroDecimal - NumeroBinario.BinarioDecimal(b.GetNumeroBinario);
        }
        public static bool operator ==(NumeroDecimal d, NumeroBinario b)
        {
            return d.GetNumeroDecimal == NumeroBinario.BinarioDecimal(b.GetNumeroBinario);
        }
        public static bool operator !=(NumeroDecimal d, NumeroBinario b)
        {
            return !(d == b);
        }
        public static implicit operator NumeroDecimal(NumeroBinario numero)
        {
            return new NumeroDecimal(NumeroBinario.BinarioDecimal(numero.GetNumeroBinario));
        }
        public static explicit operator NumeroDecimal(double numero)
        {
            return new NumeroDecimal(numero);
        }
    }
}
