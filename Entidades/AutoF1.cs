using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AutoF1
    {
        short cantidadCombustible;
        bool enCompetencia;
        string escuderia;
        short numero;
        short vueltasRestantes;

        public AutoF1(string escuderia, short numero)
        {
            this.escuderia = escuderia;
            this.numero = numero;
            this.EnCompetencia = false;
            this.CantidadCombustible = 0;
            this.VueltasRestantes = 0;
        }

        public short CantidadCombustible { get => cantidadCombustible; set => cantidadCombustible = value; }
        public bool EnCompetencia { get => enCompetencia; set => enCompetencia = value; }
        public short VueltasRestantes { get => vueltasRestantes; set => vueltasRestantes = value; }

        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            return ((a1.numero == a2.numero) && (a1.escuderia == a2.escuderia));
        }
        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Numero: {this.numero}");
            sb.AppendLine($"Escuderia: {this.escuderia}");
            sb.AppendLine($"En Competencia: {this.EnCompetencia}");
            sb.AppendLine($"Cantidad de Combustible: {this.CantidadCombustible}");
            sb.AppendLine($"Vueltas Restantes: {this.VueltasRestantes}");

            return sb.ToString();
        }
    }
}
