using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    public class Alumno
    {
        string apellido;
        string nombre;
        int legajo;
        byte nota1;
        byte nota2;
        float notafinal;

        public string Apellido { get => apellido; set => apellido = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Legajo { get => legajo; set => legajo = value; }
        public byte Nota1 { get => nota1; set => nota1 = value; }
        public byte Nota2 { get => nota2; set => nota2 = value; }
        public float Notafinal { get => notafinal; set => notafinal = value; }

        public Alumno(string apellido, string nombre, int legajo)
        {
            Apellido = apellido;
            Nombre = nombre;
            Legajo = legajo;
        }

        public void Estudiar(byte notaUno, byte notaDos)
        {
            Nota1 = notaUno;
            Nota2 = notaDos;
        }
        public void CalcularFinal()
        {
            if (Nota1 >= 4 && Nota2 >= 4)
            {
                Notafinal = new Random().Next(4, 10);
            }
            else
            {
                Notafinal = -1;
            }
        }
        public string Mostrar()
        {
            string mensaje;

            if (this.Notafinal == -1)
            {
                mensaje = $"El alumno {Apellido},{Nombre} legajo nro {Legajo} tiene como Nota 1: {Nota1} y como Nota 2: {Nota2}. ALUMNO DESAPROBADO";
            }
            else
            {
                mensaje = $"El alumno {Apellido},{Nombre} legajo nro {Legajo} tiene como Nota 1: {Nota1} y como Nota 2: {Nota2}. Su nota final es: {Notafinal}";
            }

            return mensaje;
        }
    }
}
