namespace Ejercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
             * 14.	Realizar una clase llamada CalculoDeArea que posea 3 métodos de clase (estáticos) 
             *      que realicen el cálculo del área que corresponda: 
                        a.	double CalcularCuadrado(double)
                        b.	double CalcularTriangulo(double, double)
                        c.	double CalcularCirculo(double)

                        El ingreso de los datos como la visualización se deberán realizar desde el método Main().

             */
            int opcion;
            bool resultado;

            double ladoCuadrado;
            double alturaTriangulo;
            double baseTriangulo;
            double radioCirculo;

            double areaCirculo;
            double areaCuadrado;
            double areaTriangulo;

            Console.WriteLine("Que desea calcular?:\n" +
                "\t1- AREA DEL CUADRADO\n" +
                "\t2- AREA DEL TRIANGULO\n" +
                "\t3- AREA DEL CIRCULO\n");
            resultado = int.TryParse(Console.ReadLine(), out opcion);
            while (resultado == false || (opcion != 1 && opcion != 2 && opcion != 3))
            {
                Console.WriteLine("ERROR. REINGRESE UNA OPCION VALIDA");
                resultado = int.TryParse(Console.ReadLine(), out opcion);
            }
            switch (opcion)
            {
                case 1:
                    ladoCuadrado = Input.PedirNumeroDouble("Ingrese el lado del cuadrado: ", "ERROR. Ingrese el lado del cuadrado: ");
                    areaCuadrado = CalculoDeArea.CalcularCuadrado(ladoCuadrado);
                    break;
                case 2:
                    alturaTriangulo = Input.PedirNumeroDouble("Ingrese el altura del triangulo: ", "ERROR. Ingrese la altura del triangulo: ");
                    baseTriangulo = Input.PedirNumeroDouble("Ingrese el base del triangulo: ", "ERROR. Ingrese la base del triangulo: ");
                    areaTriangulo = CalculoDeArea.CalcularTriangulo(baseTriangulo, alturaTriangulo);
                    Console.WriteLine($"El area del triangulo es: {areaTriangulo}");
                    break;
                case 3:
                    radioCirculo = Input.PedirNumeroDouble("Ingrese el radio del circulo: ", "ERROR. Ingrese el radio del circulo: ");
                    areaCirculo = CalculoDeArea.CalcularCirculo(radioCirculo);
                    Console.WriteLine($"El radio del circulo es: {areaCirculo}");
                    break;
            }
        }

    }
}