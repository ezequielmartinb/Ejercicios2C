namespace Ejercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 12.	Realizar un programa que sume números enteros 
             *      hasta que el usuario lo determine, por medio de un mensaje "¿Continuar? (S/N)".
             *      
                    En el método estático ValidaS_N(char c) de la clase ValidarRespuesta, 
                    se validará el ingreso de opciones.

                    El método devolverá un valor de tipo booleano, 
                    TRUE si se ingresó una 'S' y 
                    FALSE si se ingresó cualquier otro valor.

             */
            int numero;
            int contador = 0;
            char deseaContinuar;
            do
            {
                numero = Input.PedirNumeroEntero("Ingrese un numero entero: ", "Error. Reingrese un numero entero: ");
                contador += numero;
                Console.WriteLine("Desea continuar ingresando numeros? S/N");
                while (char.TryParse(Console.ReadLine(), out deseaContinuar) == false || (deseaContinuar != 'S' && deseaContinuar != 'N'))
                {
                    Console.WriteLine("ERROR. NO INGRESO S o N. Desea seguir ingresando numeros? S/N");
                }

            } while (ValidarRespuesta.Validar_N(deseaContinuar) == true);

            Console.WriteLine($"La suma de todos los numeros ingresados es: {contador}");
        }
    }
}