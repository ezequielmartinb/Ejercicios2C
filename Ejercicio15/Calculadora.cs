using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    public class Calculadora
    {
        public static string Calcular(int numero, int numero2, char operacionMatematica)
        {
            string resultado = "";
            float resultadoDivision;

            switch (operacionMatematica)
            {
                case '+':
                    resultado = (numero + numero2).ToString();
                    break;
                case '-':
                    resultado = (numero - numero2).ToString();
                    break;
                case '/':
                    if (Validar(numero2) == true)
                    {
                        resultadoDivision = (float)numero / numero2;
                        resultado = resultadoDivision.ToString();
                    }
                    else
                    {
                        resultado = "NO SE PUEDE DIVIDIR POR CERO";
                    }
                    break;
                case '*':
                    resultado = (numero * numero2).ToString();
                    break;
            }

            return resultado;
        }
        private static bool Validar(int numero2)
        {
            if (numero2 == 0)
            {
                return false;
            }
            return true;
        }
    }
}
