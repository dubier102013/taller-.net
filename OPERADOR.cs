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
    public partial class OPERADOR : Form
    {
        TotalEntero Tentero = new TotalEntero();
        public OPERADOR()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string dato1;
            if (CblOperacion.SelectedItem == "" || TxtValor1.Text == "" || TxtValor2.Text == "") 
            {
                MessageBox.Show("Debe llenar todos los campos", "MENSAJE DE VALIDACION DE DATOS ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LblResultado.Visible = false;
                BtnLimpiar.Visible = false;
                BtnMenu.Visible = false;
                BtnSalir.Visible = false;
            }
            else
            {

            
            Tentero.setValor1(Convert.ToInt32(TxtValor1.Text));
            Tentero.setValor2(Convert.ToInt32(TxtValor2.Text));
            dato1 = Convert.ToString(CblOperacion.SelectedItem);
            Tentero.realizarOperacion(dato1);

           

            LblResultado.Text = Convert.ToString(Tentero.calcularTotaloperacion());
            LblResultado.Visible = true;
            BtnLimpiar.Visible = true;
            BtnSalir.Visible = true;
            BtnMenu.Visible = true;
            }

        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LblResultado.Visible = false;
            LblResultado.Text = "";
            TxtValor1.Text = "";
            TxtValor2.Text = "";
            TxtValor1.Focus();
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
