using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_1.Formularios
{
    public partial class FrmLpsaDolar : Form
    {
        public FrmLpsaDolar()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtLps.Clear();
            TxtDolar.Clear();
            TxtLps.Focus();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (TxtLps .Text .Trim ().Length == 0)
            {
                MessageBox.Show("No a ingresado ningun numero");
                TxtLps.Focus();
                return;
            }

            double lps, dolar;
            lps = Convert.ToDouble(TxtLps.Text);

            dolar = lps * 0.040;

            TxtDolar .Text = dolar .ToString();
        }
    }
}
