namespace Ejercicio15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 15.	Realizar un programa que permita realizar operaciones matemáticas simples 
             *      (suma, resta, multiplicación y división). 
             *      
             *      Para ello se le debe pedir al usuario que ingrese dos números y la operación que desea realizar 
             *      (pulsando el caracter +, -, * o /).
             *      
                    El usuario decidirá cuándo finalizar el programa.

                    Crear una clase llamada Calculadora que posea dos métodos estáticos (de clase):
                    a.	Calcular (público): 

                        Recibirá tres parámetros,            
                        el primer número, 
                        el segundo número 
                        y la operación matemática. 
            
                        El método devolverá el resultado de la operación.

                    b.	Validar (privado): Recibirá como parámetro el segundo número. 

                        Este método se debe utilizar sólo cuando la operación elegida sea la DIVISIÓN.
                        Este método devolverá TRUE si el número es distinto de CERO.

             */
            int numero1;
            int numero2;
            char operacionMatematica;
            string resultado;
            char opcion;

            do
            {
                numero1 = Input.PedirNumeroEntero("Ingrese un numero: ", "Error. Reingrese un numero valido:");
                numero2 = Input.PedirNumeroEntero("Ingrese otro numero: ", "Error. Reingrese un numero valido:");
                Console.WriteLine("Ingrese la operacion matematica que desea realizar (+ - / *): ");
                operacionMatematica = Input.PedirCaracterEspecial("Ingrese la operacion matematica que desea realizar (+ - / *): ", "ERROR. Reingrese una operacion matematica valida: ");

                resultado = Calculadora.Calcular(numero1, numero2, operacionMatematica);

                Console.WriteLine($"El resultado de {numero1}{operacionMatematica}{numero2} es: {resultado}");

                opcion = Input.DeseaContinuar("Desea continuar? S/N", "ERROR. VALOR INGRESADO INVALIDO", 'S', 'N');

            } while (opcion == 'S');

        }
    }
}