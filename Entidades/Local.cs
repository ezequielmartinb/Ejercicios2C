﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Local : Llamada
    {
        private float costo;

        public Local(Llamada llamada, float costo) : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.costo = costo;
        }
        public Local(string nroOrigen, float duracion, string nroDestino, float costo) : this(new Llamada(duracion, nroDestino, nroOrigen), costo)
        {

        }

        public float CostoLlamada { get => CalcularCosto(); }

        public new string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.Append("Costo llamada: ");
            sb.AppendLine(this.CostoLlamada.ToString());
            sb.AppendLine("---------------------");
            return sb.ToString();
        }
        private float CalcularCosto()
        {
            return this.costo * base.Duracion;
        }
    }
}
