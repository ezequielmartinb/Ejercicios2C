using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PuestoAtencion
    {
        private static int numeroActual;
        Puesto puesto;

        static PuestoAtencion()
        {
            numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }

        public static int NumeroActual { get => numeroActual++; }

        public bool Atender(Cliente cli)
        {
            Thread.Sleep(1000);
            return true;
        }
    }
}
