using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        string nombre;
        int numero;

        public Cliente(int numero)
        {
            this.numero = numero;
        }

        public Cliente(string nombre, int numero) : this(numero)
        {
            this.Nombre = nombre;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Numero { get => numero; }

        public static bool operator ==(Cliente c1, Cliente c2)
        {
            return c1.Numero == c2.Numero;
        }
        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }
    }
}
