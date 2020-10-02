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
    public partial class FrmSalario : Form
    {
        public FrmSalario()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtDias.Clear();
            TxtSal.Clear();
            TxtValor.Clear();
            TxtDias.Focus();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (TxtDias .Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese un dato");
                TxtDias.Focus();
                return;
            }

            if (TxtValor .Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese un dato");
                TxtValor.Focus();
                return;
            }
            double dias, valor, salario;
            dias = Convert.ToDouble(TxtDias.Text );
            valor = Convert.ToDouble(TxtValor.Text);

            salario = dias * valor;

            TxtSal .Text = salario.ToString();
            
        }
    }
}
