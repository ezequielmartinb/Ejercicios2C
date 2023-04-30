using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SobreSobrescrito : Sobrescrito
    {
        public override string MiPropiedad
        {
            get
            {
                return miAtributo;
            }
        }
        public override string MiMetodo()
        {
            return MiPropiedad;
        }
    }
}
