using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        public Centralita()
        {
            listaDeLlamadas = new List<Llamada>();
        }
        public Centralita(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;
        }
        public List<Llamada> Llamadas { get => listaDeLlamadas; }

        public float GananciaPorLocal
        {
            get
            {
                float acumulador = 0;
                foreach (Llamada item in Llamadas)
                {
                    if (item is Local)
                    {
                        acumulador += ((Local)item).CostoLlamada;
                    }
                }
                return acumulador;
            }
        }
        public float GananciaPorProvincial
        {
            get
            {
                float acumulador = 0;
                foreach (Llamada item in Llamadas)
                {
                    if (item is Provincial)
                    {
                        acumulador += ((Provincial)item).CostoLlamada;
                    }
                }
                return acumulador;
            }
        }
        public float GananciaPorTotal
        {
            get
            {
                return GananciaPorLocal + GananciaPorProvincial;
            }
        }

        private float CalcularGanancia(TipoLlamada tipo)
        {
            float ganancia = 0;
            switch (tipo)
            {
                case TipoLlamada.Local:
                    ganancia = GananciaPorLocal;
                    break;
                case TipoLlamada.Provincial:
                    ganancia = GananciaPorProvincial;
                    break;
                case TipoLlamada.Todas:
                    ganancia = GananciaPorTotal;
                    break;
            }
            return ganancia;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Razón Social: {this.razonSocial}");
            sb.AppendLine("--------------------");
            foreach (Llamada item in Llamadas)
            {
                sb.AppendLine(item.Mostrar());
            }
            sb.Append("Ganancia por Local: ");
            sb.AppendLine(GananciaPorLocal.ToString());
            sb.AppendLine("---------------------");
            sb.Append("Ganancia por Provincial: ");
            sb.AppendLine(GananciaPorProvincial.ToString());
            sb.AppendLine("---------------------");
            sb.Append("Ganancia Total: ");
            sb.AppendLine(GananciaPorTotal.ToString());
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        public void OrdenarLlamadas()
        {
            Llamadas.Sort(Llamada.OrdenarPorDuracion);
        }


    }
}
