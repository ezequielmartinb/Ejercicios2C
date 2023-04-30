using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        private long dni;
        private string nombre;

        public Persona(string nombre)
        {
            this.nombre = nombre;
        }
        public Persona(long dni, string nombre) : this(nombre)
        {
            this.dni = dni;
        }

        public long Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Nombre: ");
            sb.AppendLine(this.nombre);
            sb.AppendLine("--------------------");
            sb.Append("DNI: ");
            sb.AppendLine(this.dni.ToString());
            sb.AppendLine("--------------------");

            return sb.ToString();
        }

    }
}
