namespace Entidades
{
    public class Boligrafo
    {
        public const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(ConsoleColor color, short tinta)
        {
            this.color = color;
            this.tinta = tinta;
        }

        public ConsoleColor GetColor { get => color; }
        public short GetTinta { get => tinta; }

        private void SetTinta(short tinta)
        {
            short tintaDisponible = GetTinta;
            if (tintaDisponible > 0 && tintaDisponible < cantidadTintaMaxima)
            {
                tintaDisponible += tinta;
                this.tinta = tintaDisponible;
            }
            else
            {
                this.tinta -= tintaDisponible;
            }
        }
        public void Recargar()
        {
            int tintaDisponible = GetTinta;
            int tintaACargar = cantidadTintaMaxima - tintaDisponible;
            SetTinta((short)tintaACargar);
        }
        public bool Pintar(short gasto, out string dibujo)
        {
            bool pudoPintar = false;
            dibujo = "";

            SetTinta(gasto);

            if (GetTinta == 0)
            {
                dibujo = "NO SE PUDO PINTAR";
            }
            else
            {
                for (int i = 0; i < gasto; i++)
                {
                    dibujo += "*";
                    pudoPintar = true;
                }
            }
            return pudoPintar;
        }


    }
}