using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DirectorTecnico : Persona
    {
        DateTime fechaNacimiento;

        public DirectorTecnico(string nombre) : base(nombre)
        {

        }
        public DirectorTecnico(string nombre, DateTime fechaNacimiento) : this(nombre)
        {
            this.fechaNacimiento = fechaNacimiento;
        }

        public static bool operator ==(DirectorTecnico d1, DirectorTecnico d2)
        {
            return (d1.Nombre == d2.Nombre && d1.fechaNacimiento == d2.fechaNacimiento);
        }
        public static bool operator !=(DirectorTecnico d1, DirectorTecnico d2)
        {
            return !(d1 == d2);
        }

        public new string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Nombre: ");
            sb.AppendLine(base.Nombre);
            sb.AppendLine("--------------------");
            sb.Append("Fecha Nacimiento: ");
            sb.AppendLine($"{this.fechaNacimiento.Day}/{this.fechaNacimiento.Month}/{this.fechaNacimiento.Year}");
            sb.AppendLine("--------------------");

            return sb.ToString();
        }

    }
}
