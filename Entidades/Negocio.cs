using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Negocio
    {
        PuestoAtencion caja;
        Queue<Cliente> clientes;
        string nombre;

        private Negocio()
        {
            this.caja = new PuestoAtencion(Puesto.Caja1);
            this.clientes = new Queue<Cliente>();
        }
        public Negocio(string nombre) : this()
        {
            this.nombre = nombre;
        }
        public int ClientesPendientes
        {
            get
            {
                return this.clientes.Count;
            }
        }
          
        public Cliente? Clientes
        {
            get
            {
                if (this.clientes.Count > 0)
                {
                    return this.clientes.Dequeue();
                }
                return null;
            }
            set
            {
                if (this + value)
                {
                    this.clientes.Enqueue(value);
                }
            }

        }

        public static bool operator +(Negocio n, Cliente c)
        {
            if (n != c)
            {
                n.clientes.Enqueue(c);
                return true;
            }
            return false;
        }
        public static bool operator ==(Negocio n, Cliente c)
        {
            return n.clientes.Contains(c);
        }
        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }
        public static bool operator ~(Negocio n)
        {
            return n.caja.Atender(n.Clientes);
        }


    }
}
