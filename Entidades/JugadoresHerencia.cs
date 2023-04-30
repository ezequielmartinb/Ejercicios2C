using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class JugadoresHerencia
    {
        private string nombre;
        private int dni;
        private int partidosJugados;
        private float promedioGoles;
        private int totalGoles;

        private JugadoresHerencia()
        {

        }
        public JugadoresHerencia(int dni, string nombre) : this()
        {
            this.dni = dni;
            this.nombre = nombre;
        }
        public JugadoresHerencia(int dni, string nombre, int totalGoles, int totalPartidos) : this(dni, nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }
        public float GetPromedioGoles()
        {
            this.promedioGoles = (float)this.totalGoles / this.partidosJugados;
            return this.promedioGoles;
        }
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"DNI: {this.dni}");
            sb.AppendLine($"Partidos Jugados: {this.partidosJugados}");
            sb.AppendLine($"Goles Totales: {this.totalGoles}");
            sb.AppendLine($"Promedio Goles: {this.GetPromedioGoles()}");

            return sb.ToString();
        }
        public static bool operator ==(JugadoresHerencia j1, JugadoresHerencia j2)
        {
            return j1.dni == j2.dni;
        }
        public static bool operator !=(JugadoresHerencia j1, JugadoresHerencia j2)
        {
            return !(j1 == j2);
        }
    }
}
