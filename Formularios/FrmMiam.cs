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
    public partial class FrmMiam : Form
    {
        public FrmMiam()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (TxtMillas .Text .Trim ().Length == 0)
            {
                MessageBox.Show("Error");
                MessageBox.Show("Ingrese un valor");
                TxtMillas.Focus();
                return;
            }

            double M, m;
            M = Convert.ToDouble(TxtMillas.Text);

            m = M * 1609.34;

            Txtmetros.Text = m.ToString();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Txtmetros.Clear();
            TxtMillas.Clear();
            TxtMillas.Focus();
        }
    }
}
