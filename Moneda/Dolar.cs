using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Dolar
    {
        private double cantidad;
        private static double cotizacionRespectoDolar;

        public double Cantidad { get => cantidad; }
        public static double CotizacionRespectoDolar { get => cotizacionRespectoDolar; }

        static Dolar()
        {
            cotizacionRespectoDolar = 1;
        }
        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Dolar(double cantidad, double cotizador) : this(cantidad)
        {
            cotizacionRespectoDolar = cotizador;
        }
        public double GetCantidad()
        {
            return Cantidad;
        }
        public static double GetCotizacion()
        {
            return CotizacionRespectoDolar;
        }
        public static explicit operator Peso(Dolar dolar)
        {
            return new Peso((dolar.GetCantidad() * Peso.GetCotizacion()));
        }
        public static explicit operator Euro(Dolar dolar)
        {
            return new Euro((dolar.GetCantidad() * Euro.GetCotizacion()));
        }
        public static implicit operator Dolar(double dolar)
        {
            return new Dolar(dolar);
        }
        public static bool operator ==(Dolar d, Euro e)
        {
            return d.GetCantidad() == ((Dolar)e).GetCantidad();
        }
        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d == e);
        }
        public static bool operator ==(Dolar d, Peso p)
        {
            return d.GetCantidad() == ((Dolar)p).GetCantidad();
        }
        public static bool operator !=(Dolar d, Peso p)
        {
            return !(d == p);
        }
        public static bool operator ==(Dolar d, Dolar d2)
        {
            return d.GetCantidad() == d2.GetCantidad();
        }
        public static bool operator !=(Dolar d, Dolar d2)
        {
            return !(d == d2);
        }
        public static Dolar operator +(Dolar d, Euro e)
        {
            return new Dolar(d.GetCantidad() + ((Dolar)e).GetCantidad());
        }
        public static Dolar operator -(Dolar d, Euro e)
        {
            return new Dolar(d.GetCantidad() - ((Dolar)e).GetCantidad());
        }
        public static Dolar operator +(Dolar d, Peso p)
        {
            return new Dolar(d.GetCantidad() + ((Dolar)p).GetCantidad());
        }
        public static Dolar operator -(Dolar d, Peso p)
        {
            return new Dolar(d.GetCantidad() - ((Dolar)p).GetCantidad());
        }
    }
}
