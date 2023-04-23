using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Competencia
    {
        short cantidadCompetidores;
        short cantidadVueltas;
        List<AutoF1> competidores;

        private Competencia()
        {
            competidores = new List<AutoF1>();
        }
        public Competencia(short cantidadVueltas, short cantidadCompetidores) : this()
        {
            this.cantidadVueltas = cantidadVueltas;
            this.cantidadCompetidores = cantidadCompetidores;
        }
        public static bool operator ==(Competencia c, AutoF1 a)
        {
            foreach (AutoF1 item in c.competidores)
            {
                if (item == a)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Competencia c, AutoF1 a)
        {
            return !(c == a);
        }
        public static bool operator +(Competencia c, AutoF1 a)
        {
            Random r = new Random();
            if (c.competidores.Count < c.cantidadCompetidores && c != a)
            {
                a.EnCompetencia = true;
                a.VueltasRestantes = c.cantidadVueltas;
                a.CantidadCombustible = (short)r.Next(15, 100);
                c.competidores.Add(a);
                return true;
            }
            return false;
        }
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("------COMPETENCIA------");
            sb.AppendLine($"COMPETIDORES: {this.cantidadCompetidores}");
            foreach (AutoF1 item in this.competidores)
            {
                sb.AppendLine("----------");
                sb.AppendLine(item.MostrarDatos());
                sb.AppendLine("----------");
            }

            return sb.ToString();
        }
    }
}
