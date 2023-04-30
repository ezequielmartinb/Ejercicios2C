using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EquipoHerencia
    {
        short cantidadJugadores;
        List<JugadoresHerencia> jugadores;
        string nombre;

        private EquipoHerencia()
        {
            jugadores = new List<JugadoresHerencia>();
        }
        public EquipoHerencia(short cantidadJugadores, string nombre) : this()
        {
            this.cantidadJugadores = cantidadJugadores;
            this.nombre = nombre;
        }
        public static bool operator +(EquipoHerencia e, JugadoresHerencia j)
        {
            bool resultado = true;
            if (e.jugadores.Count < e.cantidadJugadores)
            {
                foreach (JugadoresHerencia item in e.jugadores)
                {
                    if (item == j)
                    {
                        resultado = false;
                    }
                }
                e.jugadores.Add(j);
            }
            else
            {
                resultado = false;
            }
            return resultado;

        }
    }
}
