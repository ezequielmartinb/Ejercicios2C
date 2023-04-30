using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Sobrescrito
    {
        protected string miAtributo;
        
        public Sobrescrito()
        {
            this.miAtributo = "Probar Abstractos...";
        }

        public abstract string MiPropiedad
        {
            get;
        }

        public override string ToString()
        {
            return "Este es mi metodo ToString sobrescrito!";
        }
        public override bool Equals(object? a)
        {
            bool retorno = false;

            if (a is not null)
            {
                retorno = a.GetType() == typeof(Sobrescrito);
            }

            return retorno;
        }
        public override int GetHashCode()
        {
            return 1142510187;
        }
        public abstract string MiMetodo();

    }
}
