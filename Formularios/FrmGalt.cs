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
    public partial class FrmGalt : Form
    {
        public FrmGalt()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtLitros.Clear();
            TxtGalones.Clear();
            TxtLitros.Focus();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (TxtGalones.Text.Trim().Length == 0)
            {
                MessageBox.Show("Error");
                TxtGalones.Focus();
                return;
            }
            double gal, lt;
            gal = Convert.ToDouble(TxtGalones.Text);

            lt = gal * 3.785;

            TxtLitros.Text = lt.ToString();

        }
    }
}
