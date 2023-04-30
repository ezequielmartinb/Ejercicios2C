using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public float Duracion { get => duracion; }
        public string NroDestino { get => nroDestino; }
        public string NroOrigen { get => nroOrigen; }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            if (llamada1.Duracion > llamada2.Duracion)
            {
                return -1;
            }
            return 0;
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Duración: ");
            sb.AppendLine(this.Duracion.ToString());
            sb.AppendLine("---------------------");
            sb.Append("Numero Origen: ");
            sb.AppendLine(this.NroOrigen);
            sb.AppendLine("---------------------");
            sb.Append("Numero Destino: ");
            sb.AppendLine(this.NroDestino);
            sb.AppendLine("---------------------");
            return sb.ToString();
        }
    }
}
