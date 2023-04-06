
using System.Runtime.CompilerServices;

namespace Ejercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 8.	Por teclado se ingresa el valor hora, el nombre, la antigüedad (en años) 
             *      y la cantidad de horas trabajadas en el mes de N empleados de una fábrica.
                    
                    Se pide calcular el importe a cobrar teniendo en cuenta que el total 
                    (que resulta de multiplicar el valor hora por la cantidad de horas trabajadas), 
                    hay que sumarle la cantidad de años trabajados multiplicados por $ 150, 
                    y al total de todas esas operaciones restarle el 13% en concepto de descuentos.
                    
                    Mostrar el recibo correspondiente con el nombre, la antigüedad, 
                    el valor hora, el total a cobrar en bruto, el total de descuentos y 
                    el valor neto a cobrar de todos los empleados ingresados.

                    Nota: Utilizar estructuras repetitivas y selectivas.

             * 
             * 
             */
            Empleado empleados = new Empleado();
            string nombre;
            int valorHora;
            int antiguedad;
            int horasTrabajadas;
            float sueldoNeto;
            float sueldoBruto;
            float descuento;
            char deseaContinuar;
            bool resultado;
            
            do
            {
                nombre = PedirString("Ingrese un nombre: ", "Error. Nombre invalido. Reingrese un nombre valido: ");
                valorHora = PedirNumeroEntero("Ingrese el valor de la hora (0-30000): ", "Error. Reingrese un valor de hora valido", 1, 30000);
                antiguedad = PedirNumeroEntero("Ingrese antiguedad: ", "Error. Reingrese una antiguedad valida", 1, 30);
                horasTrabajadas = PedirNumeroEntero("Ingrese horas trabajadas: ", "Error. Reingrese horas trabajadas valida", 1, 240);
                sueldoNeto = CalcularSueldoNeto(horasTrabajadas, valorHora, antiguedad, 150);
                descuento = CalcularDescuento(sueldoNeto, 13);
                sueldoBruto = CalcularSueldoBruto(horasTrabajadas, valorHora, antiguedad, 13, 150);

                empleados = new Empleado(nombre, valorHora, antiguedad, horasTrabajadas, sueldoBruto, sueldoNeto, descuento);

                Console.WriteLine("Desea agregar otro empleado? S/N");
                resultado = char.TryParse(Console.ReadLine(), out deseaContinuar);

                while (resultado == false && (deseaContinuar != 'N' || deseaContinuar != 'S'))
                {
                    Console.WriteLine("ERROR. CARACTER INVALIDO. Desea agregar otro empleado? S/N");
                    char.TryParse(Console.ReadLine(), out deseaContinuar);
                }

            } while (deseaContinuar == 'S');

            Console.WriteLine("RECIBIDO DE SUELDOS\t");
            Console.WriteLine($"NOMBRE------ANTIGUEDAD------HORAS TRABAJADAS------VALOR HORA------SUELDO BRUTO------DESCUENTO------SUELDO NETO");
            Console.WriteLine($"{empleados.Nombre}------{empleados.Antiguedad}------{empleados.HorasTrabajadas}------{empleados.ValorHora}------{empleados.SueldoBruto}------{empleados.Descuento}------{empleados.SueldoNeto}");


        }

        public static string PedirString(string mensaje, string mensajeError)
        {
            string? nombreIngresado;
            Console.WriteLine(mensaje);
            nombreIngresado = Console.ReadLine();
            while (int.TryParse(nombreIngresado, out int numero) || string.IsNullOrEmpty(nombreIngresado))
            {
                Console.WriteLine(mensajeError);
                nombreIngresado = Console.ReadLine();
            }

            return nombreIngresado;
        }
        public static int PedirNumeroEntero(string mensaje, string mensajeError, int minimo, int maximo)
        {
            int numero;
            Console.WriteLine(mensaje);

            while (int.TryParse(Console.ReadLine(), out numero) == false || numero < minimo || numero > maximo)
            {
                Console.WriteLine(mensajeError);
            }

            return numero;
        }

        public static float CalcularSueldoBruto(int horasTrabajadas, int valorHora, int antiguedad, int porcentaje, int montoAntiguedad)
        {
            float sueldoNeto;
            float sueldoBruto;
            float descuento;

            sueldoNeto = CalcularSueldoNeto(horasTrabajadas, valorHora, antiguedad, montoAntiguedad);
            descuento = CalcularDescuento(sueldoNeto, porcentaje);
            sueldoBruto = sueldoNeto - descuento;

            return sueldoBruto;
        }
        public static float CalcularSueldoNeto(int horasTrabajadas, int valorHora, int antiguedad, int montoAntiguedad)
        {
            float sueldoNeto;
            sueldoNeto = (horasTrabajadas * valorHora) + (antiguedad * montoAntiguedad);
            return sueldoNeto;
        }
        public static float CalcularDescuento(float sueldoNeto, int porcentaje)
        {
            float descuento;

            descuento = (sueldoNeto * porcentaje) / 100;

            return descuento;
        }

    }
}