using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Provincial : Llamada
    {
        protected Franja franjaHoraria;

        public Provincial(Franja franjaHoraria, Llamada llamada) : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.franjaHoraria = franjaHoraria;
        }
        public Provincial(string origen, Franja franjaHoraria, float duracion, string destino) : this(franjaHoraria, new Llamada(duracion, destino, origen))
        {

        }
        public float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }
        private float CalcularCosto()
        {
            float costo = 0;
            switch (this.franjaHoraria)
            {
                case Franja.Franja_1:
                    costo = (float)0.99 * base.Duracion;
                    break;
                case Franja.Franja_2:
                    costo = (float)1.25 * base.Duracion;
                    break;
                case Franja.Franja_3:
                    costo = (float)0.66 * base.Duracion;
                    break;
            }
            return costo;
        }
        public new string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.Append("Costo llamada: ");
            sb.AppendLine(this.CostoLlamada.ToString());
            sb.AppendLine("---------------------");
            return sb.ToString();
        }


    }
}
