using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Libro
    {
        private List<string> paginas;

        public Libro()
        {
            this.paginas = new List<string>();
        }

        public string this[int i]
        {
            get
            {
                if (i < paginas.Count && i >= 0)
                {
                    return paginas[i];
                }
                else
                {
                    return string.Empty;
                }
            }
            set
            {
                if (i > this.paginas.Count)
                {
                    this.paginas.Add(value);
                }
                else if (i >= 0)
                {
                    this.paginas.Insert(i, value);
                }
            }
        }
    }
}
