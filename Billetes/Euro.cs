using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro
    {
        private double cantidad;
        static double cotizacionRespectoDolar;

        public double Cantidad { get => cantidad; }
        public static double CotizacionRespectoDolar { get => cotizacionRespectoDolar; }

        static Euro()
        {
            cotizacionRespectoDolar = .92;
        }
        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Euro(double cantidad, double cotizacion) : this(cantidad)
        {
            cotizacionRespectoDolar = cotizacion;
        }
        public double GetCantidad()
        {
            return Cantidad;
        }
        public static double GetCotizacion()
        {
            return CotizacionRespectoDolar;
        }
        public static implicit operator Euro(double euro)
        {
            return new Euro(euro);
        }
        public static explicit operator Dolar(Euro euro)
        {
            return new Dolar(euro.GetCantidad() / Euro.GetCotizacion());
        }
        public static explicit operator Peso(Euro euro)
        {
            return (Peso)((Dolar)euro);
        }
        public static bool operator ==(Euro e1, Euro e2)
        {
            return e1.GetCantidad() == e2.GetCantidad();
        }
        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }
        public static bool operator ==(Euro e, Dolar d)
        {
            return e.GetCantidad() == ((Euro)d).GetCantidad();
        }
        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e == d);
        }
        public static bool operator ==(Euro e, Peso p)
        {
            return e.GetCantidad() == ((Euro)p).GetCantidad();
        }
        public static bool operator !=(Euro e, Peso p)
        {
            return !(e == p);
        }
        public static Euro operator+(Euro e, Peso p)
        {
            return new Euro(e.GetCantidad()+((Euro)p).GetCantidad());
        }
        public static Euro operator -(Euro e, Peso p)
        {
            return new Euro(e.GetCantidad() - ((Euro)p).GetCantidad());
        }
        public static Euro operator +(Euro e, Dolar d)
        {
            return new Euro(e.GetCantidad() + ((Euro)d).GetCantidad());
        }
        public static Euro operator -(Euro e, Dolar d)
        {
            return new Euro(e.GetCantidad() - ((Euro)d).GetCantidad());
        }
    }
}
