using Billetes;
using System.Drawing;

namespace Ejercicio23
{
    public partial class FormularioConversor : Form
    {
        public FormularioConversor()
        {
            InitializeComponent();
        }

        private void btn_LockCotizacion_Click(object sender, EventArgs e)
        {
            double auxiliarTxtDolar;
            double auxiliarTxtEuro;
            double auxiliarTxtPeso;
            if (ValidarTexto(txtCotizacionDolar, out auxiliarTxtDolar) == true && auxiliarTxtDolar == 1 &&
                ValidarTexto(txtCotizacionEuro, out auxiliarTxtEuro) == true && auxiliarTxtEuro > 0 &&
                ValidarTexto(txtCotizacionPeso, out auxiliarTxtPeso) == true && auxiliarTxtPeso > 0)
            {
                if (btn_LockCotizacion.ImageIndex == 0)
                {
                    btn_LockCotizacion.ImageIndex = 1;
                    CambiarEstado(txtCotizacionDolar, txtCotizacionEuro, txtCotizacionPeso, true);

                }
                else
                {
                    btn_LockCotizacion.ImageIndex = 0;
                    CambiarEstado(txtCotizacionDolar, txtCotizacionEuro, txtCotizacionPeso, false);
                }
            }
            else
            {
                MessageBox.Show("EL TEXTO INGRESADO ES INVALIDO");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtCotizacionDolar.Text = Dolar.GetCotizacion().ToString();
            txtCotizacionEuro.Text = Euro.GetCotizacion().ToString();
            txtCotizacionPeso.Text = Peso.GetCotizacion().ToString();

            CambiarEstado(txtEuroAEuro, txtEuroADolar, txtEuroAPeso, false);
            CambiarEstado(txtDolarAEuro, txtDolarADolar, txtDolarAPeso, false);
            CambiarEstado(txtPesoAEuro, txtPesoADolar, txtPesoAPeso, false);

            
        }

        private void btnEuro_Click(object sender, EventArgs e)
        {
            double cantidadIngresada;
            double cotizacionIngresada;
            Euro euro;

            if (ValidarTexto(txtCotizacionEuro, out cotizacionIngresada) == true && ValidarTexto(txtEuro, out cantidadIngresada) == true && cantidadIngresada > 0)
            {
                euro = new(cantidadIngresada, cotizacionIngresada);
                txtEuroAPeso.Text = (((Peso)euro).GetCantidad()).ToString();
                txtEuroADolar.Text = (((Dolar)euro).GetCantidad()).ToString();
                txtEuroAEuro.Text = euro.GetCantidad().ToString();
            }
            else
            {
                MessageBox.Show("ERROR. CANTIDAD INVALIDA");
            }
        }

        private void btnDolar_Click(object sender, EventArgs e)
        {
            double cantidadIngresada;
            double cotizacionIngresada;
            Dolar dolar;

            if (ValidarTexto(txtCotizacionDolar, out cotizacionIngresada) == true && ValidarTexto(txtDolar, out cantidadIngresada) == true && cantidadIngresada > 0)
            {
                dolar = new(cantidadIngresada, cotizacionIngresada);
                txtDolarAPeso.Text = (((Peso)dolar).GetCantidad()).ToString();
                txtDolarADolar.Text = dolar.GetCantidad().ToString();
                txtDolarAEuro.Text = (((Euro)dolar).GetCantidad()).ToString();
            }
            else
            {
                MessageBox.Show("ERROR. CANTIDAD INVALIDA");
            }

        }

        private void btnPeso_Click(object sender, EventArgs e)
        {
            double cantidadIngresada;
            double cotizacionIngresada;
            Peso peso;

            if (ValidarTexto(txtCotizacionPeso, out cotizacionIngresada) == true && ValidarTexto(txtPeso, out cantidadIngresada) == true && cantidadIngresada > 0)
            {
                peso = new(cantidadIngresada, cotizacionIngresada);
                txtPesoAPeso.Text = peso.GetCantidad().ToString();
                txtPesoADolar.Text = (((Dolar)peso).GetCantidad()).ToString();
                txtPesoAEuro.Text = (((Euro)peso).GetCantidad()).ToString();
            }
            else
            {
                MessageBox.Show("ERROR. CANTIDAD INVALIDA");
            }
        }
        private static void CambiarEstado(TextBox a, TextBox b, TextBox c, bool estado)
        {
            a.Enabled = estado;
            b.Enabled = estado;
            c.Enabled = estado;
        }
        private static bool ValidarTexto(TextBox t, out double aux)
        {
            return double.TryParse(t.Text, out aux);
        }

    }
}