namespace Ejercicio07
{
    internal class Program
    {
        /*
         * 7.	Hacer un programa que pida por pantalla la fecha de nacimiento de una persona (día, mes y año) y 
         *      calcule el número de días vividos por esa persona hasta la fecha actual (tomar la fecha del sistema
                con DateTime.Now).

                Nota: Utilizar estructuras selectivas. Tener en cuenta los años bisiestos. 
        */
        static void Main(string[] args)
        {
            DateTime fechaDeNacimiento;
            TimeSpan diasVividos;

            fechaDeNacimiento = PedirFecha("Ingrese su fecha de nacimiento (xx/xx/xxxx): ", "ERROR. Ingrese una fecha de nacimiento valida (xx/xx/xxxx): ");

            diasVividos = DateTime.Today - fechaDeNacimiento;

            Console.WriteLine($"La cantidad de dias vividos desde {fechaDeNacimiento} hasta {DateTime.Now} es: {diasVividos.Days}");

        }
        static DateTime PedirFecha(string mensaje, string mensajeError)
        {
            DateTime fechaNacimiento;
            bool resultado;

            Console.WriteLine(mensaje);

            resultado = DateTime.TryParse(Console.ReadLine(), out fechaNacimiento);

            while (resultado == false)
            {
                Console.WriteLine(mensajeError);
                resultado = DateTime.TryParse(Console.ReadLine(), out fechaNacimiento);
            }

            return fechaNacimiento;
        }
    }
}