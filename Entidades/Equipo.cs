using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        short cantidadJugadores;
        List<Jugador> jugadores;
        string nombre;

        private Equipo()
        {
            jugadores = new List<Jugador>();
        }
        public Equipo(short cantidadJugadores, string nombre) : this()
        {
            this.cantidadJugadores = cantidadJugadores;
            this.nombre = nombre;
        }
        public static bool operator +(Equipo e, Jugador j)
        {
            bool resultado = true;
            if (e.jugadores.Count < e.cantidadJugadores)
            {
                foreach (Jugador item in e.jugadores)
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
