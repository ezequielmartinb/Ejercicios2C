using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Rectangulo
    {
        private float area;
        private float perimetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;

        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            this.vertice1 = vertice1;
            this.vertice2 = new Punto(vertice3.GetX, vertice1.GetY);
            this.vertice3 = vertice3;
            this.vertice4 = new Punto(vertice1.GetX, vertice3.GetY);
            this.area = CalcularArea();
            this.perimetro = CalcularPerimetro();
        }

        public float Area { get => area; }
        public float Perimetro { get => perimetro; }
        public Punto Vertice1 { get => vertice1; }
        public Punto Vertice2 { get => vertice2; }
        public Punto Vertice3 { get => vertice3; }
        public Punto Vertice4 { get => vertice4; }

        public float CalcularArea()
        {
            return Math.Abs(this.Vertice3.GetX - this.Vertice4.GetX) * Math.Abs(this.Vertice4.GetY - this.Vertice1.GetY);
        }
        public float CalcularPerimetro()
        {
            return (2 * (Math.Abs(Vertice3.GetX - Vertice4.GetX) + Math.Abs(Vertice4.GetY - Vertice1.GetY)));
        }
    }
}
