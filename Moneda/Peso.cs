namespace Billetes
{
    public class Peso
    {
        private double cantidad;
        private static double cotizacionRespectoDolar;

        public double Cantidad { get => cantidad; }

        public static double CotizacionRespectoDolar { get => cotizacionRespectoDolar; set => cotizacionRespectoDolar = value; }

        static Peso()
        {
            cotizacionRespectoDolar = 216.36;
        }
        public Peso(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Peso(double cantidad, double cotizacion) : this(cantidad)
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
        public static void SetCotizacion(double valor)
        {
            cotizacionRespectoDolar = valor;
        }
        public static implicit operator Peso(double pesos)
        {
            return new Peso(pesos);
        }
        public static explicit operator Dolar(Peso pesos)
        {
            return new Dolar(pesos.GetCantidad() / Peso.GetCotizacion());
        }
        public static explicit operator Euro(Peso pesos)
        {
            return (Euro)((Dolar)pesos);
        }
    }
}