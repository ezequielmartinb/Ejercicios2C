using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    public class CalculoDeArea
    {
        public static double CalcularCuadrado(double ladoCuadrado)
        {
            double areaCuadrado;

            areaCuadrado = Math.Pow(ladoCuadrado, 2);

            return areaCuadrado;
        }
        public static double CalcularTriangulo(double baseTriangulo, double alturaTriangulo)
        {
            double areaTriangulo;

            areaTriangulo = alturaTriangulo * baseTriangulo;

            return areaTriangulo;
        }
        public static double CalcularCirculo(double radioCirculo)
        {
            double areaCirculo;
            double cuadradoDelRadioCirculo;

            cuadradoDelRadioCirculo = Math.Pow(radioCirculo, 2);
            areaCirculo = cuadradoDelRadioCirculo * Math.PI;

            return areaCirculo;
        }

    }
}
