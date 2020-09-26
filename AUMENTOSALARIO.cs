using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tallernet
{
    public partial class AUMENTOSALARIO : Form
    {
        Aumento salario = new Aumento();
        public AUMENTOSALARIO()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double antoguedada;
            if (TxtSalario.Text=="" ||TxtAnitguedad.Text=="")
            {
                MessageBox.Show("Debe llenar todos los campos", "MENSAJE DE VALIDACION DE DATOS ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LblResultado.Visible = false;
                BtnLimpiar.Visible = false;
                BtnMenu.Visible = false;
                BtnSalir.Visible = false;
            }
            else
            {
                salario.setSalario(Convert.ToDouble(TxtSalario.Text));
                antoguedada = (Convert.ToDouble(TxtAnitguedad.Text));
                salario.setAntiguedad(antoguedada);
                salario.RAumento(antoguedada);

                LblResultado.Text="Su nuevo salario es : "+ Convert.ToString(salario.calcularTotalAumento());
                LblResultado.Visible = true;
            }


        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LblResultado.Visible = false;
            LblResultado.Text = "";
            TxtAnitguedad.Text = "";
            TxtSalario.Text = "";
            TxtSalario.Focus();
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            Form1 MEnupp = new Form1();
            MEnupp.Show();
            this.Hide();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
