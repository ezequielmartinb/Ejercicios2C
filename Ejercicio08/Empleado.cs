using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio08
{
    public class Empleado
    {
        string nombre;
        int valorHora;
        int antiguedad;
        int horasTrabajadas;
        float sueldoBruto;
        float sueldoNeto;
        float descuento;

        public Empleado()
        {

        }

        public Empleado(string nombre, int valorHora, int antiguedad, int horasTrabajadas, float sueldoBruto, float sueldoNeto, float descuento)
        {
            this.Nombre = nombre;
            this.ValorHora = valorHora;
            this.Antiguedad = antiguedad;
            this.HorasTrabajadas = horasTrabajadas;
            this.SueldoBruto = sueldoBruto;
            this.SueldoNeto = sueldoNeto;
            this.Descuento = descuento;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int ValorHora { get => valorHora; set => valorHora = value; }
        public int Antiguedad { get => antiguedad; set => antiguedad = value; }
        public int HorasTrabajadas { get => horasTrabajadas; set => horasTrabajadas = value; }
        public float SueldoBruto { get => sueldoBruto; set => sueldoBruto = value; }
        public float SueldoNeto { get => sueldoNeto; set => sueldoNeto = value; }
        public float Descuento { get => descuento; set => descuento = value; }
    }
}
