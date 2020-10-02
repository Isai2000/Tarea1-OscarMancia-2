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
    public partial class FrmMiaKm : Form
    {
        public FrmMiaKm()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtMillas.Clear();
            TxtKm.Clear();
            TxtMillas.Focus();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (TxtMillas .Text .Trim ().Length == 0)
            {
                MessageBox.Show("Error");
                TxtMillas.Focus();
                return;
            }
            double M, Km;
            M = Convert.ToDouble(TxtMillas.Text);

            Km = M * 1.609;

            TxtKm.Text = Km.ToString();

        }
    }
}
