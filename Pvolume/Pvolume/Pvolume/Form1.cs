using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pvolume
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btmCalcular_Click(object sender, EventArgs e)
        {
            double vlrRaio, vlrAltura;
            if ((!double.TryParse(txtRaio.Text, out vlrRaio))
                || (!double.TryParse(txtAltura.Text, out vlrAltura)))
                {
                MessageBox.Show("Valores inválidos!");
                txtRaio.Focus();
                }
            else
            {
                double volume;
                volume = Math.PI * Math.Pow(vlrRaio, 2) * vlrAltura;
                txtVolume.Text = volume.ToString("N2");
            }
        }

        private void txtRaio_Validated(object sender, EventArgs e)
        {
            double vlrRaio;

                if (!double.TryParse(txtRaio.Text, out vlrRaio))
            {
                MessageBox.Show("Raio inválido!");
            }
        }

        private void txtAltura_Validated(object sender, EventArgs e)
        {
            double VlrAltura;
            if (!Double.TryParse(txtAltura.Text, out VlrAltura))
            {
                MessageBox.Show("Altura inválida!");
            }
        }
    }
}
